using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;
using Svg.Transforms;

namespace SvgExtractor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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

        private void DoItButton_Click(object sender, EventArgs e)
        {
            var renderService = new RenderService();
            var elementlist = renderService.duet(PathTextBox.Text);
            SvgTrackBar.Maximum = elementlist.Count;
            SvgTrackBar.Value = elementlist.Count;
        }


        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void ScrollChainged_event(object sender, EventArgs e)
        {
            DrawSvg($"svg-{SvgTrackBar.Value}.svg");
        }

        private void DrawSvg(string path)
        {
            var svgDoc = SvgDocument.Open(path);
            svgDoc.Transforms = new SvgTransformCollection { new SvgScale(2, 2) };
            svgDoc.Width = new SvgUnit(svgDoc.Width.Type, svgDoc.Width * 2);
            svgDoc.Height = new SvgUnit(svgDoc.Height.Type, svgDoc.Height * 2);
            var svg = svgDoc.Draw();
            pictureBox.Image = new Bitmap(svg, new Size(50, 50));
        }


    }
}
