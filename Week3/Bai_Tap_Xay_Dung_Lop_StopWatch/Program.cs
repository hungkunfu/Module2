using System;

namespace Bai_Tap_Xay_Dung_Lop_StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
          TV tv = new TV();
          tv.Tunon();
          tv.Setchannel(45);
          tv.SetVolumn(5);

          Console.WriteLine("Tv1's channel is  and volumn level is ");
        }
    }
    public class TV
    {
        int chanal = 1;
        int volume = 1;
        bool on = false;
        public TV()
        {
        }
        public void Tunon()
        {
            on = true;
        }
        public void TunOf()
        {
            on = false;
        }
        public void Setchannel(int newChannel)
        {
            if (on && newChannel >= 1 && newChannel <= 120)
            {
                chanal = newChannel;
            }
        }
        public void SetVolumn(int newVolumn)
        {
            if (on && newVolumn >= 1 && newVolumn <= 7)
            {
                volume = newVolumn;
            }

        }
        public void chanalUp()
        {
            if (on && chanal < 120)
            {
                chanal++;
            }
        }
        public void chanaDown()
        {
            if (on && chanal > 1)
            {
                chanal--;
            }
        }
        public void VolumeUp()
        {
            if (on && volume < 7)
            {
                volume++;
            }
        }
        public void VolumeDown()
        {
            if (on && volume > 1)
            {
                volume--;
            }
        }
    }
}
