using System.Reflection.Metadata.Ecma335;

namespace TriangleScaling
{
    public partial class Form1 : Form
    {
        private PointF[] currentTriangle;
        private Matrix3x3 scalingMatrix;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += PictureBox_Paint;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(currentTriangle != null ) 
                g.DrawPolygon(Pens.Green, currentTriangle);
        }

        private void btnGenerateOriginal_Click(object sender, EventArgs e)
        {
            GenerateRandomTriangle();
            pictureBox1.Invalidate();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            GenerateRandomScaling();
            PointF[] scaledTriangle=MultiplyMatrix(currentTriangle, scalingMatrix);
            Graphics g=pictureBox1.CreateGraphics();
            g.DrawPolygon(Pens.Red, scaledTriangle);
        }

        private void GenerateRandomTriangle()
        {
            Random random = new Random();
            currentTriangle = new PointF[]
            {
                new PointF(random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height)),
                new PointF(random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height)),
                new PointF(random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height))
            };
        }

        private void GenerateRandomScaling()
        {
            Random random = new Random();
            float scalingFactor=(float)(random.NextDouble() * 1.9 + 0.1);
            scalingMatrix=new Matrix3x3(scalingFactor, 0, 0, 0, scalingFactor, 0, 0, 0, 1);
        }
       
        private PointF[] MultiplyMatrix(PointF[] input, Matrix3x3 matrix)
        {
            PointF[] result = new PointF[input.Length];
            for (int i=0; i < input.Length;i++)
            {
                float x = input[i].X;
                float y = input[i].Y;

                result[i] = new PointF(
                    matrix[0, 0] * x + matrix[0, 1] * y + matrix[0, 2],
                    matrix[1, 0] * x + matrix[1, 1] * y + matrix[1, 2]);
            }
            return result;
        }
    }
}