namespace KnPictureViewer
{
    partial class frmEntryPoint
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
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.timerChangePhoto = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(1184, 486);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(201, 17);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "(C) 2012, Kn Video Studio LLC";
            // 
            // timerChangePhoto
            // 
            this.timerChangePhoto.Enabled = true;
            this.timerChangePhoto.Interval = 10000;
            this.timerChangePhoto.Tick += new System.EventHandler(this.backgroundChangeTimerTick);
            // 
            // frmEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1397, 512);
            this.Controls.Add(this.lblDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntryPoint";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KnPictureViewer_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KnPictureViewer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KnPictureViewer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Timer timerChangePhoto;
    }
}

