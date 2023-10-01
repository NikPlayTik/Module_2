using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle_ : Shape
    {
        private double radius;
        public Circle_(double radius)
        {
            this.radius = radius;
        }
        // метод нахождения площади круга
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        // метод нахождения периметра круга
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Rectangle_ : Shape
    {
        private double length;
        private double width;

        public Rectangle_(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // метод нахождения площади прямоугольника
        public override double Area()
        {
            return length * width;
        }
        // метод нахождения периметра прямоугольника
        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }

    public class Inh_Poly
    {
        public void OutputData()
        {
            // ввод данных
            Console.WriteLine("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину и ширину прямоугольника: ");
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            // создание объектов
            Circle_ circle = new Circle_(radius);
            Rectangle_ rectangle = new Rectangle_(length, width);

            // вывод результатов
            Console.WriteLine($"Площадь круга: {circle.Area():F3}");
            Console.WriteLine($"Периметр круга: {circle.Perimeter():F3}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area():F3}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter():F3}");
            Console.ReadLine();
        }
    }
}
