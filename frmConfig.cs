using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using KnPictureViewer.Rss;

namespace KnPictureViewer
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();

            // Load the text boxes from the current settings
            try
            {
                backgroundImageFolderTextBox.Text = Properties.Settings.Default.BackgroundImagePath;
                rssFeedTextBox.Text = Properties.Settings.Default.RssFeedUri;
            }
            catch
            {
                MessageBox.Show("There was a problem reading in the settings for your screen saver.");
            }
        }

        private void UpdateApply()
        {
            if (Properties.Settings.Default.BackgroundImagePath != backgroundImageFolderTextBox.Text
                  || Properties.Settings.Default.RssFeedUri != rssFeedTextBox.Text)
                applyButton.Enabled = true;
            else
                applyButton.Enabled = false;
        }

        private void ApplyChanges()
        {
            Properties.Settings.Default.BackgroundImagePath = backgroundImageFolderTextBox.Text;
            Properties.Settings.Default.RssFeedUri = rssFeedTextBox.Text;
            Properties.Settings.Default.Save();
        }




        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyChanges();
            }
            catch (ConfigurationException)
            {
                MessageBox.Show("Your settings couldn't be saved.  Make sure that you have a .config file in the same directory as your screensaver.", "Failed to Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            applyButton.Enabled = false;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            try
            {
                RssFeed.FromUri(rssFeedTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Not a valid RSS feed.", "Not a valid RSS feed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Valid RSS feed.", "Valid RSS feed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Open a file open dialog to choose an image

            DialogResult result = backgroundImageFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                backgroundImageFolderTextBox.Text = backgroundImageFolderBrowser.SelectedPath;
                UpdateApply();
            }
        }

        private void rssFeedTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateApply();
        }

        private void backgroundImageFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateApply();
        }
    }
}
