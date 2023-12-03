namespace TriangleScaling
{
    internal class Matrix3x3
    {
        private float[,] elements;
        public Matrix3x3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
        {
            elements = new float[3, 3]
            {
                {m11, m12, m13 },
                {m21, m22, m23},
                {m31, m32, m33}
            };
        }

        //indexarea matricii pentru accesarea elementelor
        public float this[int row, int col] 
        {
            get { return elements[row, col]; }
        }
    }
}