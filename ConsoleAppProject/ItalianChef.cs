using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Italian Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Italian Chef makes special Dish of lasagna");
        }
    }
}
