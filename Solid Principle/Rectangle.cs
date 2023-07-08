﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle(int width , int height)
        {
            this.width = width;
            this.height = height;
        }
        
        public int MyProperty { get; set; }
        public override void Area()
        {
            Console.WriteLine($"The Area = {width * height} ");
        }
    }
}
