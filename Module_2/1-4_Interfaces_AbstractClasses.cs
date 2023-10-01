using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public interface IDrawable
    {
        void Draw();
    }

    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Нарисуем круг");
        }
    }

    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Нарисуем прямоугольник");
        }
    }

    public class Triangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Нарисуем треугольник");
        }
    }

    public class Intf_Abst
    {
        public void DrawI()
        {
            // создание объектов Circle, Rectangle и Triangle
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            // создание массив объекто реализующих интерфейс IDrawable
            IDrawable[] shapes = 
            {   circle, 
                rectangle, 
                triangle 
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
            }
            Console.ReadLine();
        }
    }
}
