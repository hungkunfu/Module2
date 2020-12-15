namespace Bai_Tap_Lop2D_3D
{
    public class Point2D
    {
        private float x;
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        private float y;
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point2D() { }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        private float getxy;
        public float GetXY
        {
            get { return getxy; }
            set { getxy = value; }
        }

        public string ToString()
        {
            return $"{x}\t\t\t{y}";
        }


    }
}