namespace MidpointLineAlg
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Random rnd = new Random();
        Color color;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            string selectedColor = comboBox1.SelectedItem.ToString() ?? "Negru";
            color = SelectedColor(selectedColor);

            Point p1 = new Point(rnd.Next(pictureBox1.Width), rnd.Next(pictureBox1.Height));
            Point p2 = new Point(rnd.Next(pictureBox1.Width), rnd.Next(pictureBox1.Height));
            
            g.FillEllipse(new SolidBrush(Color.Blue), p1.X - 4, p1.Y - 4, 8, 8);
            g.FillEllipse(new SolidBrush(Color.Red), p2.X - 4, p2.Y - 4, 8, 8);

            if (p2.X < p1.X)
            {
                Point p = new Point(p1.X, p1.Y);
                p1 = new Point(p2.X, p2.Y);
                p2 = p;
            }
            if (p2.X - p1.X >= Math.Abs(p2.Y - p1.Y))
            {
                int direction = 1;
                if (p2.Y < p1.Y)
                    direction = -1;
                MidPointLineLow(p1, p2, direction, color);
            }
            else
            {
                if (p2.Y < p1.Y)
                {
                    Point p = new Point(p1.X, p1.Y);
                    p1 = new Point(p2.X, p2.Y);
                    p2 = p;
                }
                int direction = 1;
                if (p2.X < p1.X)
                    direction = -1;
                MidPointLineHigh(p1, p2, direction, color);
            }
            pictureBox1.Image = bmp;
        }

        //panta mai apropiata de orizontala
        void MidPointLineLow(Point p1, Point p2, int direction, Color color)
        {
            int dx = p2.X - p1.X, dy = Math.Abs(p2.Y - p1.Y);
            int d = 2 * dy - dx;
            int incrE = 2 * dy, incrNE = 2 * (dy - dx);
            int x = p1.X, y = p1.Y;

            bmp.SetPixel(x, y, color);
            while (x < p2.X)
            {
                if (d < 0)
                    d += incrE;
                else
                {
                    d += incrNE;
                    y += direction;
                }
                x++;

                bmp.SetPixel(x, y, color);
            }
        }

        //panta mai apropiata de verticala
        void MidPointLineHigh(Point p1, Point p2, int direction, Color color)
        {
            int dx = Math.Abs(p2.X - p1.X), dy = p2.Y - p1.Y;
            int d = 2 * dy - dx;
            int incrE = 2 * dx, incrNE = 2 * (dx - dy);
            int x = p1.X, y = p1.Y;

            bmp.SetPixel(x, y, color);

            while (y < p2.Y)
            {
                if (d < 0)
                    d += incrE;
                else
                {
                    d += incrNE;
                    x += direction;
                }
                y++;

                bmp.SetPixel(x, y, color);
            }
        }

        private Color SelectedColor(string colorName)
        {
            switch (colorName)
            {
                case "Negru":
                    return Color.Black;
                case "Albastru":
                    return Color.Blue;
                case "Rosu":
                    return Color.Red;
                case "Verde":
                    return Color.Green;
                case "Roz":
                    return Color.Pink;
                case "Mov":
                    return Color.Purple;
                default:
                    return Color.Black;

            }
        }
    }
}