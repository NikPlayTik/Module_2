using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    class Person
    {
        private string name;
        private byte age;
        private bool isValidAge;
        private string address;

        public Person()
        {
            isValidAge = false;
        }
        public void SetInfo()
        {
            Console.Write("Введите имя: ");
            this.name = Console.ReadLine();
            while (!isValidAge)
            {
                Console.Write("Введите возвраст: ");
                if (byte.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= 120)
                {
                    isValidAge = true;
                }
                else
                {
                    Console.WriteLine("Некорректный возраст. Введите корректный возраст от 0 до 120");
                }
            }
            Console.Write("Введите адрес: ");
            this.address = Console.ReadLine();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Адрес: {address}");
            Console.ReadKey();
        }
    }
}
