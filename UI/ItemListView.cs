using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace KnPictureViewer.UI
{

    public class ItemListView<T> : IDisposable where T : IItem
    {
        private const float percentOfArticleDisplayBoxToFillWithText = 0.5f;
        private const float percentOfFontHeightForSelectionBox = 1.5f;
        private const int padding = 20;

        private Point location;
        private Size size;

        private string title;
        private Font itemFont;
        private Font titleFont;
        private Color backColor;
        private Color borderColor;
        private Color foreColor;
        private Color titleBackColor;
        private Color titleForeColor;
        private Color selectedForeColor;
        private Color selectedBackColor;
        private float itemFontHeight;
        private int selectedIndex = 0;
        private IList<T> items;
       private int maxItemsToShow;
       private int minItemsToShow;

        private int NumArticles { get { return Math.Min(items.Count, maxItemsToShow); } }
        private int NumArticleRows { get { return Math.Max(NumArticles, minItemsToShow); } }

        public Point Location { get { return location; } set { location = value; } }
        public Size Size { get { return size; } set { size = value; } }

        public Color ForeColor { get { return foreColor; } set { foreColor = value; } }
        public Color BackColor { get { return backColor; } set { backColor = value; } }
        public Color BorderColor { get { return borderColor; } set { borderColor = value; } }
        public Color TitleForeColor { get { return titleForeColor; } set { titleForeColor = value; } }
        public Color TitleBackColor { get { return titleBackColor; } set { titleBackColor = value; } }
        public Color SelectedForeColor { get { return selectedForeColor; } set { selectedForeColor = value; } }
        public Color SelectedBackColor { get { return selectedBackColor; } set { selectedBackColor = value; } }
        public int MaxItemsToShow { get { return maxItemsToShow; } set { maxItemsToShow = value; } }
        public int MinItemsToShow { get { return minItemsToShow; } set { minItemsToShow = value; } }
        public int SelectedIndex { get { return selectedIndex; } }
        public T SelectedItem { get { return items[selectedIndex]; } }

        public int RowHeight
        {
            get
            {
                return size.Height / (NumArticleRows + 2);
            }
        }

        public Font ItemFont
        {
            get
            {

                itemFontHeight = (float)(percentOfArticleDisplayBoxToFillWithText * RowHeight);
                if (itemFont == null || itemFont.Size != itemFontHeight)
                {
                    itemFont = new Font("Microsoft Sans Serif", itemFontHeight, GraphicsUnit.Pixel);
                }
                return itemFont;
            }
        }

        public Font TitleFont
        {
            get
            {

                float titleFontHeight = (float)(percentOfArticleDisplayBoxToFillWithText * 2 * RowHeight);
                if (titleFont == null || titleFont.Size != titleFontHeight)
                {
                    titleFont = new Font("Microsoft Sans Serif", titleFontHeight, GraphicsUnit.Pixel);
                }
                return titleFont;
            }
        }

        public void NextArticle()
        {
            if (selectedIndex < NumArticles - 1)
                selectedIndex++;
            else
                selectedIndex = 0;
        }

        public void PreviousArticle()
        {
            if (selectedIndex > 0)
                selectedIndex--;
            else
                selectedIndex = NumArticles - 1;
        }

        public ItemListView(string title, IList<T> items)
        {
            if (items == null)
                throw new ArgumentException("Items cannot be null", "items");

            this.items = items;
            this.title = title;
        }

        public void Paint(PaintEventArgs args)
        {
            Graphics g = args.Graphics;


            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            DrawBackground(g);

            for (int index = 0; index < items.Count && index < maxItemsToShow; index++)
            {
                DrawItemTitle(g, index);
            }


            DrawTitle(g);
        }

        private void DrawBackground(Graphics g)
        {
            using (Brush backBrush = new SolidBrush(BackColor))
            using (Pen borderPen = new Pen(BorderColor, 4))
            {
                g.FillRectangle(backBrush, new Rectangle(Location.X + 4, Location.Y + 4, Size.Width - 8, Size.Height - 8));
                g.DrawRectangle(borderPen, new Rectangle(Location, Size));
            }
        }


        private void DrawItemTitle(Graphics g, int index)
        {

            StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;
            Rectangle articleRect = new Rectangle(Location.X + padding, Location.Y + (int)(index * RowHeight) + padding, Size.Width - (2 * padding), (int)(percentOfFontHeightForSelectionBox * itemFontHeight));

            Color textBrushColor = ForeColor;
            if (index == SelectedIndex)
            {
                textBrushColor = SelectedForeColor;
                using (Brush backBrush = new SolidBrush(SelectedBackColor))
                {
                    g.FillRectangle(backBrush, articleRect);
                }
            }

            string textToDraw = items[index].Title;
            using (Brush textBrush = new SolidBrush(textBrushColor))
            {
                g.DrawString(textToDraw, ItemFont, textBrush, articleRect, stringFormat);
            }
        }


        private void DrawTitle(Graphics g)
        {
            Point titleLocation = new Point(Location.X + padding, Location.Y + Size.Height - (RowHeight) - padding);
            Size titleSize = new Size(Size.Width - (2 * padding), 2 * RowHeight);
            Rectangle titleRectangle = new Rectangle(titleLocation, titleSize);

            using (Brush titleBackBrush = new SolidBrush(TitleBackColor))
            {
                g.FillRectangle(titleBackBrush, titleRectangle);
            }


            StringFormat titleFormat = new StringFormat(StringFormatFlags.LineLimit);
            titleFormat.Alignment = StringAlignment.Far;
            titleFormat.Trimming = StringTrimming.EllipsisCharacter;
            using (Brush titleBrush = new SolidBrush(TitleForeColor))
            {
                g.DrawString(title, titleFont, titleBrush, titleRectangle, titleFormat);
            }
        }


        public void Dispose()
        {
            if (itemFont != null)
                itemFont.Dispose();
            if (titleFont != null)
                titleFont.Dispose();
        }
    }
}
