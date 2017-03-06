namespace KnPictureViewer
{
    partial class frmConfig
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.backgroundImageFolderTextBox = new System.Windows.Forms.TextBox();
            this.backgroundImageLabel = new System.Windows.Forms.Label();
            this.rssGroupBox = new System.Windows.Forms.GroupBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.rssFeedLabel = new System.Windows.Forms.Label();
            this.rssFeedTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.backgroundImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.imageGroupBox.SuspendLayout();
            this.rssGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imageGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rssGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 346);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.browseButton);
            this.imageGroupBox.Controls.Add(this.backgroundImageFolderTextBox);
            this.imageGroupBox.Controls.Add(this.backgroundImageLabel);
            this.imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGroupBox.Location = new System.Drawing.Point(4, 155);
            this.imageGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.imageGroupBox.Size = new System.Drawing.Size(501, 143);
            this.imageGroupBox.TabIndex = 5;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "Background Image";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(9, 84);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 28);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // backgroundImageFolderTextBox
            // 
            this.backgroundImageFolderTextBox.Location = new System.Drawing.Point(9, 50);
            this.backgroundImageFolderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundImageFolderTextBox.Name = "backgroundImageFolderTextBox";
            this.backgroundImageFolderTextBox.Size = new System.Drawing.Size(400, 22);
            this.backgroundImageFolderTextBox.TabIndex = 1;
            // 
            // backgroundImageLabel
            // 
            this.backgroundImageLabel.AutoSize = true;
            this.backgroundImageLabel.Location = new System.Drawing.Point(9, 25);
            this.backgroundImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backgroundImageLabel.Name = "backgroundImageLabel";
            this.backgroundImageLabel.Size = new System.Drawing.Size(221, 17);
            this.backgroundImageLabel.TabIndex = 0;
            this.backgroundImageLabel.Text = "Background image directory path:";
            // 
            // rssGroupBox
            // 
            this.rssGroupBox.Controls.Add(this.validateButton);
            this.rssGroupBox.Controls.Add(this.rssFeedLabel);
            this.rssGroupBox.Controls.Add(this.rssFeedTextBox);
            this.rssGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rssGroupBox.Location = new System.Drawing.Point(4, 4);
            this.rssGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.rssGroupBox.Name = "rssGroupBox";
            this.rssGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.rssGroupBox.Size = new System.Drawing.Size(501, 143);
            this.rssGroupBox.TabIndex = 4;
            this.rssGroupBox.TabStop = false;
            this.rssGroupBox.Text = "RSS Feed";
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(9, 84);
            this.validateButton.Margin = new System.Windows.Forms.Padding(4);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(100, 28);
            this.validateButton.TabIndex = 2;
            this.validateButton.Text = "Validate";
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // rssFeedLabel
            // 
            this.rssFeedLabel.AutoSize = true;
            this.rssFeedLabel.Location = new System.Drawing.Point(9, 25);
            this.rssFeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rssFeedLabel.Name = "rssFeedLabel";
            this.rssFeedLabel.Size = new System.Drawing.Size(91, 17);
            this.rssFeedLabel.TabIndex = 1;
            this.rssFeedLabel.Text = "RSS 2.0 URI:";
            // 
            // rssFeedTextBox
            // 
            this.rssFeedTextBox.Location = new System.Drawing.Point(9, 50);
            this.rssFeedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rssFeedTextBox.Name = "rssFeedTextBox";
            this.rssFeedTextBox.Size = new System.Drawing.Size(400, 22);
            this.rssFeedTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.Controls.Add(this.applyButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.okButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 306);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 36);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applyButton.Location = new System.Drawing.Point(397, 4);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(179, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(289, 4);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // backgroundImageFolderBrowser
            // 
            this.backgroundImageFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 346);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmConfig";
            this.Text = "KnPictureViewer Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.imageGroupBox.ResumeLayout(false);
            this.imageGroupBox.PerformLayout();
            this.rssGroupBox.ResumeLayout(false);
            this.rssGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox backgroundImageFolderTextBox;
        private System.Windows.Forms.Label backgroundImageLabel;
        private System.Windows.Forms.GroupBox rssGroupBox;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label rssFeedLabel;
        private System.Windows.Forms.TextBox rssFeedTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.OpenFileDialog backgroundImageOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog backgroundImageFolderBrowser;
    }
}