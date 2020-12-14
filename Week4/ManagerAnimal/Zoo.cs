using System;
namespace ManagerAnimal
{

    public class Zoo
    {
        public static Cage[] cagelist = new Cage[0];
        public void AddCage(int CageNumber)
        {
            Cage cage = new Cage();
            Array.Resize(ref cagelist, cagelist.Length + 1);
            cagelist[cagelist.Length - 1] = cage;
            System.Console.WriteLine("CAGE");

        }
    }
}