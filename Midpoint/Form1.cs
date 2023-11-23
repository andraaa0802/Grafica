using System;
using System.Drawing;
using System.Windows.Forms;

namespace Midpoint
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Resize += Form1_Resize;
        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawAxes(e.Graphics);
            DrawLineMidPoint(100, 400, 200, 300, e.Graphics);
        }

       private void DrawAxes(Graphics graphics)
        {
            int arrowSize = 5; // Adjust this value to control the size of the arrow
            Font zeroFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular); // Adjust the font size as needed

            // Draw x-axis with arrow
            graphics.DrawLine(Pens.Black, 0, ClientSize.Height / 2, ClientSize.Width, ClientSize.Height / 2);
            graphics.DrawLine(Pens.Black, ClientSize.Width - arrowSize, ClientSize.Height / 2 - arrowSize, ClientSize.Width, ClientSize.Height / 2);
            graphics.DrawLine(Pens.Black, ClientSize.Width - arrowSize, ClientSize.Height / 2 + arrowSize, ClientSize.Width, ClientSize.Height / 2);

            // Draw y-axis with arrow
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2 - arrowSize, arrowSize, ClientSize.Width / 2, 0);
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2 + arrowSize, arrowSize, ClientSize.Width / 2, 0);

            // Draw zero as a number in the third quadrant
            string zeroSymbol = "0";
            SizeF zeroSymbolSize = graphics.MeasureString(zeroSymbol, zeroFont);
            float zeroX = (ClientSize.Width / 2) - (zeroSymbolSize.Width / 2) - zeroSymbolSize.Width / 2; // Adjusted for more leftward positioning
            float zeroY = (ClientSize.Height / 2) + (zeroSymbolSize.Height / 2) - zeroSymbolSize.Height / 2;
            graphics.DrawString(zeroSymbol, zeroFont, Brushes.Black, zeroX, zeroY);
        }

        private void DrawLineMidPoint(int x1, int y1, int x2, int y2, Graphics graphics)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            int d = dy-(dx/2);

            int x = x1;
            int y = y1;

            // Offset to center the graphic on the form
            int xOffset = ClientSize.Width / 2;
            int yOffset = ClientSize.Height / 2;

            // Draw the starting point
            graphics.FillRectangle(Brushes.Black, x + xOffset, -y + yOffset, 1, 1);


            while (x < x2)
            {
                x++;
                if (d < 0)
                {
                    d += dy;
                }
                else
                {
                    d += (dy-dx);
                    y++;
                }

                // Draw the line with respect to the center of the form
                graphics.FillRectangle(Brushes.Black, x + xOffset, -y + yOffset, 1, 1);
                
            }
        }

    }
}