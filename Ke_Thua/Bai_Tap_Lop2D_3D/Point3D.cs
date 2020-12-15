namespace Bai_Tap_Lop2D_3D
{
    public class Point3D : Point2D
    {
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\t\t\t {z}";
        }
        public float GetXYZ
        {
            get { return getxyz; }
            set { getxyz = value; }
        }

    }
}