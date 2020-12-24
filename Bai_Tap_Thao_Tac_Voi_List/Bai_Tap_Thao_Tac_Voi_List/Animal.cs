using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bai_Tap_Thao_Tac_Voi_List
{
    class Animal
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Animal(string name) {
            Name = name;
        }
        

    }
    class SortPersonByName : IComparer<Animal>
    {
       

        public int Compare([AllowNull] Animal x, [AllowNull] Animal y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}
