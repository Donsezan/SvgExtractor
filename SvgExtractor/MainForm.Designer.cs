namespace SvgExtractor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Pathlabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.DoItButton = new System.Windows.Forms.Button();
            this.SvgTrackBar = new System.Windows.Forms.TrackBar();
            this.Savelabel = new System.Windows.Forms.Label();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SvgSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SvgTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pathlabel
            // 
            this.Pathlabel.AutoSize = true;
            this.Pathlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pathlabel.Location = new System.Drawing.Point(9, 7);
            this.Pathlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pathlabel.Name = "Pathlabel";
            this.Pathlabel.Size = new System.Drawing.Size(47, 22);
            this.Pathlabel.TabIndex = 0;
            this.Pathlabel.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.AllowDrop = true;
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTextBox.Location = new System.Drawing.Point(63, 5);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(478, 27);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTextBox_DragEnterEvent);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(547, 5);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(69, 26);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.previewWebBrowser);
            this.groupBox1.Controls.Add(this.DoItButton);
            this.groupBox1.Controls.Add(this.SvgTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(603, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SVG preview";
            // 
            // previewWebBrowser
            // 
            this.previewWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.previewWebBrowser.Location = new System.Drawing.Point(8, 18);
            this.previewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWebBrowser.Name = "previewWebBrowser";
            this.previewWebBrowser.ScriptErrorsSuppressed = true;
            this.previewWebBrowser.ScrollBarsEnabled = false;
            this.previewWebBrowser.Size = new System.Drawing.Size(590, 289);
            this.previewWebBrowser.TabIndex = 8;
            // 
            // DoItButton
            // 
            this.DoItButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoItButton.Location = new System.Drawing.Point(8, 312);
            this.DoItButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoItButton.Name = "DoItButton";
            this.DoItButton.Size = new System.Drawing.Size(57, 45);
            this.DoItButton.TabIndex = 7;
            this.DoItButton.Text = "Do It";
            this.DoItButton.UseVisualStyleBackColor = true;
            this.DoItButton.Click += new System.EventHandler(this.DoItButton_Click);
            // 
            // SvgTrackBar
            // 
            this.SvgTrackBar.Location = new System.Drawing.Point(70, 312);
            this.SvgTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SvgTrackBar.Name = "SvgTrackBar";
            this.SvgTrackBar.Size = new System.Drawing.Size(529, 45);
            this.SvgTrackBar.TabIndex = 1;
            this.SvgTrackBar.Scroll += new System.EventHandler(this.ScrollChanged_event);
            // 
            // Savelabel
            // 
            this.Savelabel.AutoSize = true;
            this.Savelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savelabel.Location = new System.Drawing.Point(9, 409);
            this.Savelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Savelabel.Name = "Savelabel";
            this.Savelabel.Size = new System.Drawing.Size(42, 20);
            this.Savelabel.TabIndex = 4;
            this.Savelabel.Text = "Path";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTextBox.Location = new System.Drawing.Point(63, 409);
            this.SaveTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(395, 26);
            this.SaveTextBox.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(462, 409);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 26);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(544, 409);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(72, 26);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SvgSaveFileDialog
            // 
            this.SvgSaveFileDialog.Title = "SVG save dialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(626, 442);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.Savelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.Pathlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "SvgExtractor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_Event);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SvgTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pathlabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar SvgTrackBar;
        private System.Windows.Forms.Label Savelabel;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DoItButton;
        private System.Windows.Forms.WebBrowser previewWebBrowser;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.SaveFileDialog SvgSaveFileDialog;
    }
}

