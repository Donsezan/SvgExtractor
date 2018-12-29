using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SvgExtractor
{
    public partial class Form1 : Form
    {
        private string PathToSvg;
        private bool PageLoaded;

        public Form1()
        {
            IeFeatureControlFix();
            InitializeComponent();
        }

        private void IeFeatureControlFix()
        {
            int BrowserVer, RegVal;

            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PathTextBox.Text = dialog.FileName;
                }
            }
        }

        private void PathTextBox_DragEnterEvent(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                PathTextBox.Text = files[0];
            }
        }

        private async void DoItButton_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate(PathTextBox.Text);
            var renderService = new RenderService();
            var elementlist = await renderService.duet(PathTextBox.Text);
            SvgTrackBar.Minimum = 1;
            SvgTrackBar.Maximum = elementlist.Count - 1;
            SvgTrackBar.Value = elementlist.Count - 1;
            PathToSvg = AppDomain.CurrentDomain.BaseDirectory + $"Temp\\svg-{SvgTrackBar.Value}.svg";
        }
        
        private void ScrollChainged_event(object sender, EventArgs e)
        {
            PathToSvg = AppDomain.CurrentDomain.BaseDirectory + $"Temp\\svg-{SvgTrackBar.Value}.svg";
            webBrowser1.Navigate(PathToSvg);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveTextBox.Text == string.Empty)
            {
                SaveTextBox.Text = PathToSvg;
            }
            else
            {
                try
                {
                    File.Copy(PathToSvg, SaveTextBox.Text);
                }
                catch
                {
                    //ignore
                }
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            SaveTextBox.Text = PathToSvg;
            Clipboard.SetFileDropList(new StringCollection { PathToSvg });
        }
        
        private void DocumentComplited_event(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            PageLoaded = true;
        }
    }
}
