namespace Bai_Tap_Lam_Them
{
    public class Swap
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        private int number3;
        private int Number4;
        public Swap()
        {

        }
        public int Number3
        {
            get { return number3; }
            set { number3 = value; }
        }
        public int number4
        {
            get => Number4;
            set => number4 = value;
        }
        public void swap()
        {
            int tmp = Number1;
            Number1 = Number2;
            Number2 = tmp;


        }
    }

}