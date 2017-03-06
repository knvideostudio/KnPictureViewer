using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using KnPictureViewer.UI;
using KnPictureViewer.Rss;

namespace KnPictureViewer
{
    public partial class frmEntryPoint : Form
    {

        private RssFeed rssFeed;

        private ItemListView<RssItem> rssView;
        private ItemDescriptionView<RssItem> rssDescriptionView;

        private List<Image> backgroundImages;
        private int currentImageIndex;

       private bool isActive = false;
      private Point mouseLocation;

        private List<string> imageExtensions = new List<string>(new string[] { "*.bmp", "*.gif", "*.png", "*.jpg", "*.jpeg" });


        public frmEntryPoint()
        {
            InitializeComponent();

            SetupScreenSaver();
            LoadBackgroundImage();
            LoadRssFeed();

            rssView = new ItemListView<RssItem>(rssFeed.MainChannel.Title, rssFeed.MainChannel.Items);
            InitializeRssView();

            rssDescriptionView = new ItemDescriptionView<RssItem>();
            InitializeRssDescriptionView();
        }

        private void SetupScreenSaver()
        {
          
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
          
            this.Capture = true;

            Cursor.Hide();
            Bounds = Screen.PrimaryScreen.Bounds;
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = false;
            DoubleBuffered = true;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LoadBackgroundImage()
        {
 
            backgroundImages = new List<Image>();
            currentImageIndex = 0;

            if (Directory.Exists(Properties.Settings.Default.BackgroundImagePath))
            {
                try
                {
                    LoadImagesFromFolder();
                }
                catch
                {
                   
                    LoadDefaultBackgroundImages();
                }
            }

     
            if (backgroundImages.Count == 0)
            {
                LoadDefaultBackgroundImages();
            }
        }

        private void LoadImagesFromFolder()
        {
            DirectoryInfo backgroundImageDir = new DirectoryInfo(Properties.Settings.Default.BackgroundImagePath);
   
            foreach (string imageExtension in imageExtensions)
            {
                foreach (FileInfo file in backgroundImageDir.GetFiles(imageExtension))
                {
                    
                    try
                    {
                        Image image = Image.FromFile(file.FullName);
                        backgroundImages.Add(image);
                    }
                    catch (OutOfMemoryException)
                    {
                        // If the image can't be loaded, move on.
                        continue;
                    }
                }
            }
        }


        private void LoadDefaultBackgroundImages()
        {
            // If the background images could not be loaded for any reason
            // use the image stored in the resources 
            backgroundImages.Add(Properties.Resources.knboat1); // 1
            backgroundImages.Add(Properties.Resources.knboat2); // 2
            backgroundImages.Add(Properties.Resources.knboot); // 3
            backgroundImages.Add(Properties.Resources.knCubes); // 4
            backgroundImages.Add(Properties.Resources.knflower1); // 5
            backgroundImages.Add(Properties.Resources.knflower2); // 6
            backgroundImages.Add(Properties.Resources.knfruit); // 7
            backgroundImages.Add(Properties.Resources.kngreen); // 8
            backgroundImages.Add(Properties.Resources.knhouse1); // 9
            backgroundImages.Add(Properties.Resources.knhouse2); // 10
            backgroundImages.Add(Properties.Resources.knhouse3); // 11
            backgroundImages.Add(Properties.Resources.knpeaches); // 12
            backgroundImages.Add(Properties.Resources.knplien); // 13
            backgroundImages.Add(Properties.Resources.knpot); // 14
            backgroundImages.Add(Properties.Resources.knroster1); // 15
            backgroundImages.Add(Properties.Resources.knroster2); // 16
            backgroundImages.Add(Properties.Resources.knroster3); // 17
            backgroundImages.Add(Properties.Resources.knsun); // 18
            backgroundImages.Add(Properties.Resources.kntractor); // 19
            backgroundImages.Add(Properties.Resources.kntree); // 20
        }

        private void LoadRssFeed()
        {
           // try
           // {
            //    rssFeed = RssFeed.FromUri(Properties.Settings.Default.RssFeedUri);
           // }
           // catch
           // {
                rssFeed = RssFeed.FromText(Properties.Resources.DefaultRSSText);
          //  }
        }

        private void InitializeRssView()
        {
            rssView.BackColor = Color.FromArgb(120, 240, 234, 232);
            rssView.BorderColor = Color.White;
            rssView.ForeColor = Color.FromArgb(255, 40, 40, 40);
            rssView.SelectedBackColor = Color.FromArgb(200, 105, 61, 76);
            rssView.SelectedForeColor = Color.FromArgb(255, 204, 184, 163);
            rssView.TitleBackColor = Color.Empty;
            rssView.TitleForeColor = Color.FromArgb(255, 240, 234, 232);
            rssView.MaxItemsToShow = 20;
            rssView.MinItemsToShow = 15;
            rssView.Location = new Point(Width / 10, Height / 10);
            rssView.Size = new Size(Width / 2, Height / 2);
        }

        private void InitializeRssDescriptionView()
        {
            rssDescriptionView.DisplayItem = rssView.SelectedItem;
            rssDescriptionView.ForeColor = Color.FromArgb(255, 240, 234, 232);
            rssDescriptionView.TitleFont = rssView.TitleFont;
            rssDescriptionView.LineColor = Color.FromArgb(120, 240, 234, 232);
            rssDescriptionView.LineWidth = 2f;
            rssDescriptionView.FadeTimer.Tick += new EventHandler(FadeTimer_Tick);
            rssDescriptionView.FadeTimer.Interval = 40;
            rssDescriptionView.Location = new Point(3 * Width / 4, Height / 3);
            rssDescriptionView.Size = new Size(Width / 4, Height / 2);
            rssDescriptionView.FadingComplete += new EventHandler(rssItemView_FadingComplete);
        }

        private void KnPictureViewer_MouseMove(object sender, MouseEventArgs e)
        {
            // Set IsActive and MouseLocation only the first time this event is called.
            if (!isActive)
            {
                mouseLocation = MousePosition;
                isActive = true;
            }
            else
            {
                // If the mouse has moved significantly since first call, close.
                if ((Math.Abs(MousePosition.X - mouseLocation.X) > 10) ||
                    (Math.Abs(MousePosition.Y - mouseLocation.Y) > 10))
                {
                    Close();
                }
            }
        }

        private void KnPictureViewer_KeyDown(object sender, KeyEventArgs e)
        {
            Close();

        }

        private void KnPictureViewer_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.DrawImage(backgroundImages[currentImageIndex], 0, 0, Size.Width, Size.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            rssView.Paint(e);
            rssDescriptionView.Paint(e);
        }

        private void backgroundChangeTimerTick(object sender, EventArgs e)
        {
           currentImageIndex = (currentImageIndex + 1) % backgroundImages.Count;
        }

        void FadeTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        void rssItemView_FadingComplete(object sender, EventArgs e)
        {
            rssView.NextArticle();
            rssDescriptionView.DisplayItem = rssView.SelectedItem;
        }


    }
}
