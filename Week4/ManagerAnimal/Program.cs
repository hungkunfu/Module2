using System;

namespace ManagerAnimal
{
    class Program
    {
        public static Cage cage = new Cage();
        public static Zoo zoo = new Zoo();
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Menu menus = new Menu();
                menus.menu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("==Danh sach CAGE==");
                        AddCages();
                        break;
                    case 2:
                        System.Console.WriteLine("Remove Cage");
                        break;
                    case 3:
                        AddAnimals();
                        System.Console.WriteLine("Danh sach sau khi them");
                        break;
                    case 4:
                        RemoveAnimal();

                        break;
                    case 5:
                       cage.Show();

                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static void AddCages()
        {
            int cages;
            System.Console.Write("Nhap vao Cage : ");
            cages = Int32.Parse(Console.ReadLine());
            zoo.AddCage(cages);


        }
      
        // public static 
        public static void ADDAnimal()
        {
            int age;
            string name, description;
            System.Console.Write("Nhap vao ten dog vat : ");
            name = Console.ReadLine();
            System.Console.Write("Nhap vao tuoi cua dv :");
            age = int.Parse(Console.ReadLine());
            System.Console.Write("Nhap vao Mo ta DV :");
            description = Console.ReadLine();
            cage.AddAnimal(name, age, description);

        }
        // public static void ShowAnimal()
        // {
        //     cage.ShowAnimalList();
        // }
        public static void RemoveAnimal()
        {
            string name;
            System.Console.Write("Nhap vao ten muon xoa : ");
            name = Console.ReadLine();
            cage.Remove(name);
            System.Console.WriteLine("===Danh sach sau khi xoa===");
            cage.ShowAnimalList();
        }
        public static void AddAnimals()
        {
            int age;
            string name, description;
            string speak;
            System.Console.Write("Nhap vao ten Name : ");
            name = Console.ReadLine();
            System.Console.Write("Nhap vao tuoi cua dv :");
            age = int.Parse(Console.ReadLine());
            System.Console.Write("Nhap vao Mo ta DV :");
            description = Console.ReadLine();
            System.Console.Write("Nhap vao tieng keu : ");
            speak = Console.ReadLine();
            // zoo.ArrayListCage(name, age, description, speak);
        }
    }
}

