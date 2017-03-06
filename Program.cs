using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace KnPictureViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmEntryPoint());
            if (args.Length > 0)
            {
                // Get the 2 character command line argument
                string arg = args[0].ToLower(CultureInfo.InvariantCulture).Trim().Substring(0, 2);
                switch (arg)
                {
                    case "/c":
                        // Show the options dialog
                       // DisplaySettings();
                        break;
                    case "/p":
                        // Don't do anything for preview
                        break;
                    case "/s":
                        // Show screensaver form
                        DisplayKnPictureViewer();
                        break;
                    default:
                        MessageBox.Show("Invalid command line argument :" + arg, "Invalid Command Line Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // If no arguments were passed in, show the screensaver
                DisplayKnPictureViewer();
            }
        }

        static void DisplaySettings()
        {
            frmConfig frmCfg = new frmConfig();
            Application.Run(frmCfg);
        }

        static void DisplayKnPictureViewer()
        {
            //frmRegistration frm = new frmRegistration();
            //Application.Run(frm);
            frmEntryPoint frm = new frmEntryPoint();
            Application.Run(frm);
        }

    }
}
