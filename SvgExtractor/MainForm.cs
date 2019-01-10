using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SvgExtractor
{
    public partial class MainForm : Form
    {
        public const string TempFolder = "Temp";
        public const string FileExtension = "svg";
        private string _pathToSvg;

        public MainForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            IeFeatureControlFix();
            InitializeComponent();
            FileHelper.CheckAndPreparingFolder();
            FileHelper.PreparingLoadingHtml();
        }

        private void IeFeatureControlFix()
        {
            int browserVer, regVal;

            // get the installed IE version
            using (var wb = new WebBrowser())
            {
                browserVer = wb.Version.Major;
            }

            // set the appropriate IE version
            if (browserVer >= 11)
                regVal = 11001;
            else if (browserVer == 10)
                regVal = 10001;
            else if (browserVer == 9)
                regVal = 9999;
            else if (browserVer == 8)
                regVal = 8888;
            else
                regVal = 7000;

            // set the actual key
            using (var key = Registry.CurrentUser.CreateSubKey(
                @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                if (key != null && key.GetValue(Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    key.SetValue(Process.GetCurrentProcess().ProcessName + ".exe", regVal,
                        RegistryValueKind.DWord);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (!OpenButton.Enabled) return;
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK) PathTextBox.Text = dialog.FileName;
            }
        }

        private void PathTextBox_DragEnterEvent(object sender, DragEventArgs e)
        {
            if (!OpenButton.Enabled) return;
            var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0) PathTextBox.Text = files[0];
        }

        private async void DoItButton_Click(object sender, EventArgs e)
        {
            if (!DoItButton.Enabled) return;
            string svgPath;
            if (PathTextBox.Text != string.Empty)
            {
                svgPath = PathTextBox.Text;
            }
            else if (previewWebBrowser.Url != null)
            {
                svgPath = previewWebBrowser.Url?.ToString();
                PathTextBox.Text = svgPath;
            }
            else
            {
                return;
            }

            BlockAllButtons();
            previewWebBrowser.Navigate(FileHelper.ResourceTempFolder + "\\Loading.html");
            var elementList = await Task.Factory.StartNew(async () =>
            {
                var svgList = await RenderService.Start(svgPath);
                return svgList;

            }).ConfigureAwait(true);

            SvgTrackBar.Minimum = 0;
            SvgTrackBar.Maximum = elementList.Result.Count - 1;
            SvgTrackBar.Value = elementList.Result.Count - 1;
            SetPathToSvg(SvgTrackBar.Value);

            previewWebBrowser.Navigate(_pathToSvg);
            EnableAllButtons();
        }

        private void ScrollChanged_event(object sender, EventArgs e)
        {
            if (!SvgTrackBar.Enabled | _pathToSvg == null) return;
            SetPathToSvg(SvgTrackBar.Value);
            previewWebBrowser.Navigate(_pathToSvg);
        }

        private void SetPathToSvg(int index)
        {
            _pathToSvg = AppDomain.CurrentDomain.BaseDirectory +
                         $@"{TempFolder}\{FileExtension}-{index}.{FileExtension}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!SaveButton.Enabled | _pathToSvg == null) return;
            SvgSaveFileDialog.InitialDirectory = @"C:\";
            SvgSaveFileDialog.RestoreDirectory = true;
            SvgSaveFileDialog.DefaultExt = FileExtension;
            SvgSaveFileDialog.CheckPathExists = true;
            if (SvgSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveTextBox.Text = SvgSaveFileDialog.FileName;
                File.Copy(_pathToSvg, SaveTextBox.Text);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!CopyButton.Enabled | _pathToSvg == null) return;
            Clipboard.SetFileDropList(new StringCollection {_pathToSvg});
            SaveTextBox.Text = @"Done: Copied to clipboard";
        }

        private void BlockAllButtons()
        {
            OpenButton.Enabled = false;
            DoItButton.Enabled = false;
            SvgTrackBar.Enabled = false;
            SaveButton.Enabled = false;
            CopyButton.Enabled = false;
        }

        private void EnableAllButtons()
        {
            OpenButton.Enabled = true;
            DoItButton.Enabled = true;
            SvgTrackBar.Enabled = true;
            SaveButton.Enabled = true;
            CopyButton.Enabled = true;
        }

        private void FormClosing_Event(object sender, FormClosingEventArgs e)
        {
            FileHelper.DeleteTempFolder();
        }
    }
}