using System;
using System.Windows.Forms;
using System.Drawing;

namespace KnPictureViewer.UI
{


    public class ItemDescriptionView<T> : IDisposable where T : IItem
    {
        private Point location;
        private Size size;

        private static Brush textDrawingBrush = Brushes.Black;
        private Color lineColor;
        private float lineWidth;
        private Rectangle textRect;
        private Timer fadeTimer;
        private Color foreColor;
        private Font titleFont;
        private T displayItem;

        private int textAlpha = 0;
        private int textAlphaDelta = 4;
        private int textAlphaMax = 200;

        public T DisplayItem { get { return displayItem; } set { displayItem = value; } }
        public Point Location { get { return location; } set { location = value; } }
        public Size Size { get { return size; } set { size = value; } }
        public Color ForeColor { get { return foreColor; } set { foreColor = value; } }
        public Color LineColor { get { return lineColor; } set { lineColor = value; } }
        public Font TitleFont { get { return titleFont; } set { titleFont = value; } }
        public float LineWidth { get { return lineWidth; } set { lineWidth = value; } }
        public Timer FadeTimer { get { return fadeTimer; } }

        public event EventHandler FadingComplete;


        public ItemDescriptionView()
        {
            fadeTimer = new Timer();
            fadeTimer.Tick += new EventHandler(scrollTimer_Tick);
            fadeTimer.Enabled = true;
            fadeTimer.Start();
        }

        public void Paint(PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float lineLeftX = Size.Width / 4;
            float lineRightX = 3 * Size.Width / 4;
            int lineVerticalBuffer = Size.Height / 50;
            float lineTopY = Location.Y + lineVerticalBuffer;
            float lineBottomY = Location.Y + Size.Height - lineVerticalBuffer;

            using (Pen linePen = new Pen(lineColor, lineWidth))
            {
                e.Graphics.DrawLine(linePen, Location.X + lineLeftX, lineTopY, Location.X + lineRightX, lineTopY);
                e.Graphics.DrawLine(linePen, Location.X + lineLeftX, lineBottomY, Location.X + lineRightX, lineBottomY);
            }

            using (StringFormat textFormat = new StringFormat(StringFormatFlags.LineLimit))
            {
                textFormat.Alignment = StringAlignment.Near;
                textFormat.LineAlignment = StringAlignment.Near;
                textFormat.Trimming = StringTrimming.EllipsisWord;
                int textVerticalBuffer = 4 * lineVerticalBuffer;
                textRect = new Rectangle(Location.X, Location.Y + textVerticalBuffer, Size.Width, Size.Height - (2 * textVerticalBuffer));
                using (Brush textBrush = new SolidBrush(Color.FromArgb(textAlpha, ForeColor)))
                {
                    e.Graphics.DrawString(displayItem.Description, titleFont, textBrush, textRect, textFormat);
                }
            }
        }

        private void scrollTimer_Tick(object sender, EventArgs e)
        {
            textAlpha += textAlphaDelta;
            if (textAlpha >= textAlphaMax)
            {
                textAlphaDelta *= -1;
            }
            else if (textAlpha <= 0)
            {
                FadingComplete(this, new EventArgs());
                textAlpha = 0;
                textAlphaDelta *= -1;
            }
        }


        public void Dispose()
        {
            fadeTimer.Dispose();
        }
    }
}
