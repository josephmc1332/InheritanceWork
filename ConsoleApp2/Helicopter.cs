﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Helicopter : Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Aircraft is flying");
        }
        public override void Move()
        {
            Fly();
        }
        public override void Start()
        {
            Console.WriteLine("Aircraft engine spins up");


        }
        public override void Fuel()
        {
            Console.WriteLine("Filled with jp-8");
        }


        public override void Maintain()
        {
            Console.WriteLine("PMCS");
        }
    }
}
