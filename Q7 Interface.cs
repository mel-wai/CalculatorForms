﻿using System;
namespace Interface
{
    public interface IDrawable
    {
        void draw();
    }

    public class Rectangle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Rectangle..");
        }
    }

    public class Circle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    public class Test
    {
        public static void Main()
        {
            IDrawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();
            Console.ReadLine();
        }

    }
    
}