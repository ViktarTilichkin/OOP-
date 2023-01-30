﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomeTask.Test
{
    public class Ship : Transport, ISwim
    {
        public Ship(string name, int nameOfTransport) : base(name, nameOfTransport)
        {

        }
        public override void Move()
        {
            Console.WriteLine($"{Name} {NumberOfTransport} is moving");
        }
        public void Otpliv()
        {
            Console.WriteLine($"{Name} {NumberOfTransport} uplil");
        }

        public void Pripliv()
        {
            Console.WriteLine($"{Name} {NumberOfTransport} priplil");
        }
        public override string ToString()
        {
            return $"{Name} {NumberOfTransport}";
        }
    }
}
