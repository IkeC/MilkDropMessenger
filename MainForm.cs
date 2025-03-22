using DarkModeForms;
using System.Diagnostics;
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

    private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

    private const uint WM_COPYDATA = 0x004A;

    private DarkModeCS dm;

    [StructLayout(LayoutKind.Sequential)]
    private struct COPYDATASTRUCT {
      public IntPtr dwData;
      public int cbData;
      public IntPtr lpData;
    }

    public MainForm() {
      InitializeComponent();

      dm = new DarkModeCS(this) {
        //[Optional] Choose your preferred color mode here:
        ColorMode = DarkModeCS.DisplayMode.SystemDefault
      };

#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
      txtMessage.KeyDown += new KeyEventHandler(txtBoxes_KeyDown);
      txtParameters.KeyDown += new KeyEventHandler(txtBoxes_KeyDown);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).

      // txtParameters.AutoCompleteSource = AutoCompleteSource.CustomSource;
      // txtParameters.AutoCompleteCustomSource = new AutoCompleteStringCollection();
      txtParameters.DropDownStyle = ComboBoxStyle.DropDown;
      txtParameters.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      if (MilkDropMessenger.Properties.Settings.Default.Parameters?.Count > 0) {
        txtParameters.Items.AddRange(MilkDropMessenger.Properties.Settings.Default.Parameters.Cast<string>().ToArray());
        txtParameters.Text = MilkDropMessenger.Properties.Settings.Default.Parameters[0];
      } else {
        txtParameters.Text = "font=Arial|size=32|time=3.5|x=0.5|y=0.5|bold=1|r=255|g=0|b=0|growth=2.0";
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      statusBar.Text = "";
      string partialTitle = txtWindowTitle.Text; // Replace with the actual partial title
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
        string message = "MSG|text=" + txtMessage.Text;
        if (txtParameters.Text.Length > 0) {
          message += "|" + txtParameters.Text;
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
        statusBar.Text = ($"Sent message to window titled '{foundWindowTitle}'");


        Marshal.FreeHGlobal(messagePtr);

        txtMessage.Focus();
        txtMessage.SelectAll();
      } else {
        statusBar.Text = "Window not found.";
      }
    }

    private void txtBoxes_KeyDown(object sender, KeyEventArgs e) {
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
  }
}
