namespace MidpointLineAlg
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Random rnd = new Random();
        int thickness;
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
            thickness = (int)numericUpDown1.Value;

            Point p1 = new Point(rnd.Next(pictureBox1.Width), rnd.Next(pictureBox1.Height));
            Point p2 = new Point(rnd.Next(pictureBox1.Width), rnd.Next(pictureBox1.Height));

            g.FillEllipse(new SolidBrush(Color.Blue), p1.X - 4, p1.Y - 4, thickness+8, thickness+8);
            g.FillEllipse(new SolidBrush(Color.Red), p2.X - 4, p2.Y - 4, thickness +8,thickness+8);

            if (p2.X < p1.X)
            {
                Point p = new Point(p1.X, p1.Y);
                p1 = new Point(p2.X, p2.Y);
                p2 = p;
            }
            if (p2.X - p1.X >= Math.Abs(p2.Y - p1.Y))
            {
                int sign = 1;
                if (p2.Y < p1.Y)
                    sign = -1;
                MidPointLineX(p1, p2, sign, thickness, color);
            }
            else
            {
                if (p2.Y < p1.Y)
                {
                    Point p = new Point(p1.X, p1.Y);
                    p1 = new Point(p2.X, p2.Y);
                    p2 = p;
                }
                int sign = 1;
                if (p2.X < p1.X)
                    sign = -1;
                MidPointLineY(p1, p2, sign, thickness, color);
            }
            pictureBox1.Image = bmp;
        }

        void MidPointLineX(Point p1, Point p2, int sign, int thickness, Color color)
        {
            int dx = p2.X - p1.X, dy = Math.Abs(p2.Y - p1.Y);
            int d = 2 * dy - dx;
            int incrE = 2 * dy, incrNE = 2 * (dy - dx);
            int x = p1.X, y = p1.Y;
            
            DrawPoint(x, y, thickness, color);
            while (x < p2.X)
            {
                if (d < 0)
                    d += incrE;
                else
                {
                    d += incrNE;
                    y += sign;
                }
                x++;
               
                DrawPoint(x, y, thickness, color);
            }
        }

        void MidPointLineY(Point p1, Point p2, int sign, int thickness, Color color)
        {
            int dx = Math.Abs(p2.X - p1.X), dy = p2.Y - p1.Y;
            int d = 2 * dy - dx;
            int incrE = 2 * dx, incrNE = 2 * (dx - dy);
            int x = p1.X, y = p1.Y;
            
            DrawPoint(x, y, thickness, color);

            while (y < p2.Y)
            {
                if (d < 0)
                    d += incrE;
                else
                {
                    d += incrNE;
                    x += sign;
                }
                y++;
               
                DrawPoint(x, y, thickness, color);
            }
        }

        void DrawPoint(int x, int y, int thickness,  Color color)
        {
            for (int i=-thickness/2; i<=thickness/2; i++)
            {
                for(int j=-thickness/2; j<=thickness/2; j++)
                {
                    int newX = x + i;
                    int newY= y + j;

                    if (newX >= 0 && newX < bmp.Width && newY >= 0 && newY < bmp.Height)
                        bmp.SetPixel(newX, newY, color);
                }
            }
        }

        private Color SelectedColor(string colorName)
        {
            switch(colorName)
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