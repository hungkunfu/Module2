namespace Thuc_Hanh_Tao_Lop_Chu_Nhat
{
    public class Rectangle
    {

        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private int _width;
        public  int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Rectangle(){}
        public  Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public  int GetArea()
        {
            return (Width*Height);

        }
        public  int GetPerimeter()
        {
            return (Width + Height) * 2;
        }
        public string Display(){
          return  " chieu dai " + Width + " chieu rong " + Height;

        }
    }
}