using System;
namespace Thu_Hanh_OOP
{
    public class newclass
    {
        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public newclass() { }
        public newclass(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public int GetArea()
        {
            return Width * Height;
        }
        public int Getprimeter()
        {
            return (Width + Height) * 2;
        }
        public string Print()
        {
            return "Chieu dai " + Width + " Chieu rong " + Height;
        }
    }
}