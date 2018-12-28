namespace SvgExtractor
{
    partial class Form1
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
            this.Pathlabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SvgTrackBar = new System.Windows.Forms.TrackBar();
            this.Savelabel = new System.Windows.Forms.Label();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DoItButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pathlabel
            // 
            this.Pathlabel.AutoSize = true;
            this.Pathlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pathlabel.Location = new System.Drawing.Point(11, 9);
            this.Pathlabel.Name = "Pathlabel";
            this.Pathlabel.Size = new System.Drawing.Size(57, 26);
            this.Pathlabel.TabIndex = 0;
            this.Pathlabel.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.AllowDrop = true;
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTextBox.Location = new System.Drawing.Point(79, 6);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(596, 32);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTextBox_DragEnterEvent);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(684, 6);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(86, 32);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoItButton);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.SvgTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 452);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SVG preview";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(10, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(730, 350);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // SvgTrackBar
            // 
            this.SvgTrackBar.Location = new System.Drawing.Point(87, 390);
            this.SvgTrackBar.Name = "SvgTrackBar";
            this.SvgTrackBar.Size = new System.Drawing.Size(661, 56);
            this.SvgTrackBar.TabIndex = 1;
            this.SvgTrackBar.Scroll += new System.EventHandler(this.ScrollChainged_event);
            // 
            // Savelabel
            // 
            this.Savelabel.AutoSize = true;
            this.Savelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savelabel.Location = new System.Drawing.Point(11, 511);
            this.Savelabel.Name = "Savelabel";
            this.Savelabel.Size = new System.Drawing.Size(52, 25);
            this.Savelabel.TabIndex = 4;
            this.Savelabel.Text = "Path";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTextBox.Location = new System.Drawing.Point(79, 511);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(596, 30);
            this.SaveTextBox.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(684, 511);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(86, 30);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DoItButton
            // 
            this.DoItButton.Location = new System.Drawing.Point(10, 390);
            this.DoItButton.Name = "DoItButton";
            this.DoItButton.Size = new System.Drawing.Size(71, 56);
            this.DoItButton.TabIndex = 7;
            this.DoItButton.Text = "Do it!";
            this.DoItButton.UseVisualStyleBackColor = true;
            this.DoItButton.Click += new System.EventHandler(this.DoItButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.Savelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.Pathlabel);
            this.Name = "Form1";
            this.Text = "SvgExtractor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SvgTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pathlabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar SvgTrackBar;
        private System.Windows.Forms.Label Savelabel;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DoItButton;
    }
}

