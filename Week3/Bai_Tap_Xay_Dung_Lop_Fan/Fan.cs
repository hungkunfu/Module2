using System;
namespace Bai_Tap_Xay_Dung_Lop_Fan
{
    public class Fan
    {
        // private int SLOW = 1;
        // private int MEDIUM = 2;
        // private int FAST = 3;
        private int _slow;
        public int SLOW
        {
            get { return _slow; }
            set { _slow = value; }
        }
        private int _medium;
        public int MEDIUM
        {
            get { return _medium; }
            set { _medium = value; }
        }
        private int _fast;
        public int FAST
        {
            get { return _fast; }
            set { _fast = value; }
        }
        private int _darius;
        public int DARIUS
        {
            get { return _darius; }
            set { _darius = value; }
        }
        private string _color;
        public string COLOR
        {
            get { return _color; }
            set { _color = value; }
        }


        public Fan() { }
        public Fan(int slow, int medium, string color, int darius)
        {
            _slow = slow ;
            _medium = medium ;
            _color = color =  "blue" ;
            _darius = darius = 5;

        }

        private int Speed()
        {
            return SLOW = 1;
        }
        private int Radius(){
            return DARIUS = 5;
        }
        private bool On()
        {
            return false;

        }

       public void ToString()
        {
         System.Console.WriteLine( " speed " + SLOW + " color " + COLOR + " radius " + DARIUS );  
            
        }

    }
}