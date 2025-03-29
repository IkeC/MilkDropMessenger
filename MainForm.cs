using DarkModeForms;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace MilkDropMessenger {
  public partial class MainForm : Form {
    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int GetWindowTextLength(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern IntPtr SendMessageW(IntPtr hWnd, uint Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

    [DllImport("user32.dll")]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();

    private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

    private const uint WM_COPYDATA = 0x004A;
    private const uint WM_KEYDOWN = 0x0100;
    private const uint WM_KEYUP = 0x0101;
    private const int VK_TILDE = 0xC0;

    private DarkModeCS dm;
    private System.Windows.Forms.Timer autoplayTimer;
    private int currentLineIndex = 0;
    private int autoplayRemainingS = 1;
    List<string> lines = new List<string>();

    [StructLayout(LayoutKind.Sequential)]
    private struct COPYDATASTRUCT {
      public IntPtr dwData;
      public int cbData;
      public IntPtr lpData;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct INPUT {
      public uint type;
      public InputUnion u;
    }

    [StructLayout(LayoutKind.Explicit)]
    private struct InputUnion {
      [FieldOffset(0)]
      public MOUSEINPUT mi;
      [FieldOffset(0)]
      public KEYBDINPUT ki;
      [FieldOffset(0)]
      public HARDWAREINPUT hi;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct MOUSEINPUT {
      public int dx;
      public int dy;
      public uint mouseData;
      public uint dwFlags;
      public uint time;
      public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct KEYBDINPUT {
      public ushort wVk;
      public ushort wScan;
      public uint dwFlags;
      public uint time;
      public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct HARDWAREINPUT {
      public uint uMsg;
      public ushort wParamL;
      public ushort wParamH;
    }

    public MainForm() {
      InitializeComponent();

      Assembly executingAssembly = Assembly.GetExecutingAssembly();
      var fieVersionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
      var version = fieVersionInfo.FileVersion;
      this.Text = $"MilkDrop Messenger {version}";

      dm = new DarkModeCS(this) {
        ColorMode = DarkModeCS.DisplayMode.SystemDefault
      };

      txtMessage.KeyDown += new KeyEventHandler(txtBoxes_KeyDown);
      txtParameters.KeyDown += new KeyEventHandler(txtBoxes_KeyDown);

      txtParameters.DropDownStyle = ComboBoxStyle.DropDown;
      txtParameters.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      if (MilkDropMessenger.Properties.Settings.Default.Parameters?.Count > 0) {
        txtParameters.Items.AddRange(MilkDropMessenger.Properties.Settings.Default.Parameters.Cast<string>().ToArray());
        txtParameters.Text = MilkDropMessenger.Properties.Settings.Default.Parameters[0];
      } else {
        txtParameters.Text = "size=35|time=5.0|x=0.5|y=0.5|growth=1.5";
      }

      // Fill cboFonts with available system fonts and add a blank first entry
      cboFonts.Items.Add(""); // Add a blank first entry
      using (InstalledFontCollection fontsCollection = new InstalledFontCollection()) {
        foreach (FontFamily font in fontsCollection.Families) {
          cboFonts.Items.Add(font.Name);
        }
      }

      LoadMessages();

      autoplayTimer = new System.Windows.Forms.Timer();
      autoplayTimer.Tick += AutoplayTimer_Tick;
    }

    private void button1_Click(object sender, EventArgs e) {
      SendToMilkdrop(txtMessage.Text);
      txtMessage.Focus();
      txtMessage.SelectAll();
    }

    private void SendToMilkdrop(string messageToSend) {
      statusBar.Text = "";
      string partialTitle = txtWindowTitle.Text;
      IntPtr foundWindow = IntPtr.Zero;
      StringBuilder foundWindowTitle = new StringBuilder();

      EnumWindows((hWnd, lParam) => {
        int length = GetWindowTextLength(hWnd);
        if (length == 0) return true;

        StringBuilder windowTitle = new StringBuilder(length + 1);
        GetWindowText(hWnd, windowTitle, windowTitle.Capacity);

        if (windowTitle.ToString().Contains(partialTitle)) {
          foundWindow = hWnd;
          foundWindowTitle = windowTitle;
          return false; // Stop enumeration
        }

        return true; // Continue enumeration
      }, IntPtr.Zero);

      if (foundWindow != IntPtr.Zero) {
        string message = "MSG|text=" + messageToSend;
        if (txtParameters.Text.Length > 0) {
          message += "|" + txtParameters.Text;
        }
        if (!message.Contains("font=")) {
          message += "|font=" + cboFonts.Text;
        }
        if (!message.Contains("r=") && !message.Contains("g=") && !message.Contains("b=")) {
          message += "|r=" + pnlColor.BackColor.R;
          message += "|g=" + pnlColor.BackColor.G;
          message += "|b=" + pnlColor.BackColor.B;
        }
        byte[] messageBytes = Encoding.Unicode.GetBytes(message);
        IntPtr messagePtr = Marshal.AllocHGlobal(messageBytes.Length);
        Marshal.Copy(messageBytes, 0, messagePtr, messageBytes.Length);

        COPYDATASTRUCT cds = new COPYDATASTRUCT {
          dwData = IntPtr.Zero,
          cbData = messageBytes.Length,
          lpData = messagePtr
        };

        SendMessageW(foundWindow, WM_COPYDATA, IntPtr.Zero, ref cds);
        statusBar.Text = ($"Sent '{messageToSend}' to '{foundWindowTitle}'");

        Marshal.FreeHGlobal(messagePtr);

      } else {
        statusBar.Text = "Window not found.";
      }
    }

    private void txtBoxes_KeyDown(object? sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        e.SuppressKeyPress = true; // Prevent the beep sound on Enter key press
        button1.PerformClick();
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start(new ProcessStartInfo("https://www.example.com") { UseShellExecute = true });
      OpenURL("https://github.com/milkdrop2077/MilkDrop3/issues/86#issuecomment-2367210209");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      OpenURL("https://github.com/IkeC/MilkDropMessenger");
    }

    private void MainForm_Shown(object sender, EventArgs e) {
      txtMessage.Focus();
      txtMessage.SelectAll();
      pnlColor.BackColor = Color.FromArgb(230, 0, 120);
      colorDialog1.Color = pnlColor.BackColor;
    }

    private void OpenURL(string url) {
      Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    }

    private void label4_DoubleClick(object sender, EventArgs e) {
      txtParameters.Items.Clear();
      MilkDropMessenger.Properties.Settings.Default.Parameters.Clear();
      MilkDropMessenger.Properties.Settings.Default.Save();
      statusBar.Text = "Saved parameters cleared.";
    }

    private void btnSaveParam_Click(object sender, EventArgs e) {
      if (!MilkDropMessenger.Properties.Settings.Default.Parameters.Contains(txtParameters.Text)) {
        MilkDropMessenger.Properties.Settings.Default.Parameters.Insert(0, txtParameters.Text);
        if (MilkDropMessenger.Properties.Settings.Default.Parameters?.Count > 10) {
          MilkDropMessenger.Properties.Settings.Default.Parameters.RemoveAt(10);
        }
        MilkDropMessenger.Properties.Settings.Default.Save();
      }
      if (MilkDropMessenger.Properties.Settings.Default.Parameters?.Count > 0) {
        txtParameters.Items.Clear();
        txtParameters.Items.AddRange(MilkDropMessenger.Properties.Settings.Default.Parameters.Cast<string>().ToArray());
      }
      txtParameters.Refresh();
    }

    private void chkAutoplay_CheckedChanged(object sender, EventArgs e) {
      if (chkAutoplay.Checked) {
        if (int.TryParse(txtWait.Text, out int interval)) {
          autoplayRemainingS = 1;
          autoplayTimer.Interval = 1000;
          autoplayTimer.Start();
        } else {
          statusBar.Text = "Invalid wait value. Please enter a valid number.";
        }
      } else {
        autoplayTimer.Stop();
        statusBar.Text = "";
        autoplayRemainingS = 1;
      }
    }

    private void AutoplayTimer_Tick(object? sender, EventArgs e) {
      if (lines.Count > 0) {
        if (autoplayRemainingS == 0) {
          SendToMilkdrop(lines[currentLineIndex]);
          currentLineIndex = (currentLineIndex + 1) % lines.Count;
          autoplayRemainingS = int.Parse(txtWait.Text);
        } else {
          txtAutoplay.Text = lines[currentLineIndex];
          statusBar.Text = $"Next autoplay line in {autoplayRemainingS} seconds.";
          autoplayRemainingS--;
        }
      }
    }

    private void btnFontAppend_Click(object sender, EventArgs e) {
      if (!txtParameters.Text.Contains("font=")) {
        txtParameters.Text += "|font=" + cboFonts.Text;
      } else {
        statusBar.Text = "Font already defined.";
      }
    }

    private void textBox1_Click(object sender, EventArgs e) {
      if (colorDialog1.ShowDialog() == DialogResult.OK) {
        button1.BackColor = colorDialog1.Color;
      }
    }

    private void pnlColor_Click(object sender, EventArgs e) {
      if (colorDialog1.ShowDialog() == DialogResult.OK) {
        pnlColor.BackColor = colorDialog1.Color;
      }
    }

    private void btnAppendColor_Click(object sender, EventArgs e) {
      if (!txtParameters.Text.Contains("r=") && !txtParameters.Text.Contains("g=") && !txtParameters.Text.Contains("b=")) {
        txtParameters.Text += "|r=" + pnlColor.BackColor.R;
        txtParameters.Text += "|g=" + pnlColor.BackColor.G;
        txtParameters.Text += "|b=" + pnlColor.BackColor.B;
      } else {
        statusBar.Text = "Color already defined.";
      }
    }

    private void LoadMessages() {
      currentLineIndex = 0;
      lines.Clear();
      string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MilkDropMessenger.txt");
      if (File.Exists(filePath)) {
        lines.AddRange(File.ReadAllLines(filePath));
      }

      if (lines?.Count > 0) {
        txtAutoplay.Text = lines[currentLineIndex];
      } else {
        txtAutoplay.Text = "No messages in MilkDropMessenger.txt";
        chkAutoplay.Enabled = false;
      }
    }

    private void SendPostMessage(int VKKey, string keyName) {
      IntPtr foundWindow = IntPtr.Zero;

      EnumWindows((hWnd, lParam) => {
        int length = GetWindowTextLength(hWnd);
        if (length == 0) return true;

        StringBuilder windowTitle = new StringBuilder(length + 1);
        GetWindowText(hWnd, windowTitle, windowTitle.Capacity);

        if (windowTitle.ToString().Contains(txtWindowTitle.Text)) {
          foundWindow = hWnd;
          return false; // Stop enumeration
        }

        return true; // Continue enumeration
      }, IntPtr.Zero);

      if (foundWindow != IntPtr.Zero) {
        PostMessage(foundWindow, WM_KEYDOWN, (IntPtr)VKKey, IntPtr.Zero);
        statusBar.Text = $"Pressed {keyName} in the Milkdrop window.";
      } else {
        statusBar.Text = "Milkdrop window not found.";
      }
    }

    private const int VK_SHIFT = 0x10;
    private const int VK_ALT = 0x12;

    private void SendInput(int VKKey, string keyName, bool doShift, bool doAlt) {
      IntPtr currentWindow = GetForegroundWindow();
      string partialTitle = txtWindowTitle.Text;
      IntPtr foundWindow = IntPtr.Zero;

      EnumWindows((hWnd, lParam) => {
        int length = GetWindowTextLength(hWnd);
        if (length == 0) return true;

        StringBuilder windowTitle = new StringBuilder(length + 1);
        GetWindowText(hWnd, windowTitle, windowTitle.Capacity);

        if (windowTitle.ToString().Contains(partialTitle)) {
          foundWindow = hWnd;
          return false; // Stop enumeration
        }

        return true; // Continue enumeration
      }, IntPtr.Zero);

      if (foundWindow != IntPtr.Zero) {
        SetForegroundWindow(foundWindow);

        INPUT[] inputs;

        if (doShift) {
          inputs = new INPUT[4];

          inputs[0] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = VK_SHIFT,
                dwFlags = 0 // Key down
              }
            }
          };

          inputs[1] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = (ushort)VKKey,
                dwFlags = 0 // Key down
              }
            }
          };

          inputs[2] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = (ushort)VKKey,
                dwFlags = 2 // Key up
              }
            }
          };

          inputs[3] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = VK_SHIFT,
                dwFlags = 2 // Key up
              }
            }
          };
        } else if (doAlt) {
          inputs = new INPUT[4];

          inputs[0] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = VK_ALT,
                dwFlags = 0 // Key down
              }
            }
          };

          inputs[1] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = (ushort)VKKey,
                dwFlags = 0 // Key down
              }
            }
          };

          inputs[2] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = (ushort)VKKey,
                dwFlags = 2 // Key up
              }
            }
          };

          inputs[3] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = VK_ALT,
                dwFlags = 2 // Key up
              }
            }
          };
        } else {
          inputs = new INPUT[2];

          inputs[0] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = (ushort)VKKey,
                dwFlags = 0 // Key down
              }
            }
          };

          inputs[1] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = (ushort)VKKey,
                dwFlags = 2 // Key up
              }
            }
          };
        }

        SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        statusBar.Text = $"Pressed {keyName} in the Milkdrop window.";

        SetForegroundWindow(currentWindow);
      } else {
        statusBar.Text = "Milkdrop window not found.";
      }
    }

    private const int VK_F3 = 0x72;

    private void btnF3_Click(object sender, EventArgs e) {
      SendPostMessage(VK_F3, "F3");
    }

    private const int VK_F4 = 0x73;

    private void btnF4_Click(object sender, EventArgs e) {
      SendPostMessage(VK_F4, "F4");
    }

    private const int VK_F7 = 0x76;

    private void btnF7_Click(object sender, EventArgs e) {
      SendPostMessage(VK_F7, "F7");
    }

    private const int VK_K = 0x4B;

    private void btnShiftK_Click(object sender, EventArgs e) {
      SendInput(VK_K, "Shift+K", true, false);
    }

    private const int VK_SPACE = 0x20;

    private void btnSpace_Click(object sender, EventArgs e) {
      SendPostMessage(VK_SPACE, "Space");
    }

    private const int VK_BACKSPACE = 0x08;

    private void btnBackspace_Click(object sender, EventArgs e) {
      SendPostMessage(VK_BACKSPACE, "Backspace");
    }

    private void SendUnicodeChars(string inputString) {
      IntPtr foundWindow = IntPtr.Zero;
      IntPtr currentWindow = GetForegroundWindow();

      EnumWindows((hWnd, lParam) => {
        int length = GetWindowTextLength(hWnd);
        if (length == 0) return true;

        StringBuilder windowTitle = new StringBuilder(length + 1);
        GetWindowText(hWnd, windowTitle, windowTitle.Capacity);

        if (windowTitle.ToString().Contains(txtWindowTitle.Text)) {
          foundWindow = hWnd;
          return false; // Stop enumeration
        }

        return true; // Continue enumeration
      }, IntPtr.Zero);

      if (foundWindow != IntPtr.Zero) {
        SetForegroundWindow(foundWindow);


        for (int i = 0; i < inputString.Length; i++) {
          INPUT[] inputs = new INPUT[1];
          inputs[0] = new INPUT {
            type = 1, // Keyboard input
            u = new InputUnion {
              ki = new KEYBDINPUT {
                wVk = 0,
                wScan = (ushort)inputString[i],
                dwFlags = 4, // KEYEVENTF_UNICODE
                time = 0,
                dwExtraInfo = IntPtr.Zero
              }
            }
          };
          SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
          Thread.Sleep(50);
        }

        statusBar.Text = $"Pressed {inputString} in the Milkdrop window.";

        SetForegroundWindow(currentWindow);

      } else {
        statusBar.Text = "Milkdrop window not found.";
      }
    }

    private void btnTilde_Click(object sender, EventArgs e) {
      SendUnicodeChars("~");
    }

    private const int VK_DELETE = 0x2E;

    private void btnDelete_Click(object sender, EventArgs e) {
      SendPostMessage(VK_DELETE, "Delete");
    }

    private const int VK_ENTER = 0x0D;

    private void btnAltEnter_Click(object sender, EventArgs e) {
      SendInput(VK_ENTER, "Alt+Enter", false, true);
    }

    private void btnN_Click(object sender, EventArgs e) {
      SendUnicodeChars("n");
    }

    private const int VK_F8 = 0x77;

    private void btnF8_Click(object sender, EventArgs e) {
      SendPostMessage(VK_F8, "F8");
    }

    private void btnC_Click(object sender, EventArgs e) {
      SendUnicodeChars("c");
    }

    private void btn00_Click(object sender, EventArgs e) {
      SendUnicodeChars("00");
    }

    private void btn11_Click(object sender, EventArgs e) {
      SendUnicodeChars("11");
    }

    private void btnm22_Click(object sender, EventArgs e) {
      SendUnicodeChars("22");
    }

    private void btn33_Click(object sender, EventArgs e) {
      SendUnicodeChars("33");
    }

    private void btn44_Click(object sender, EventArgs e) {
      SendUnicodeChars("44");
    }

    private void btn55_Click(object sender, EventArgs e) {
      SendUnicodeChars("55");
    }

    private void btn66_Click(object sender, EventArgs e) {
      SendUnicodeChars("66");
    }

    private void btn77_Click(object sender, EventArgs e) {
      SendUnicodeChars("77");
    }

    private void label6_DoubleClick(object sender, EventArgs e) {
      LoadMessages();
    }
  }
}
