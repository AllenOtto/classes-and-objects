﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Chef makes makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Chef makes makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes nyama choma");
        }
    }
}
