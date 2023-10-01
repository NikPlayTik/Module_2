using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public class Arbitary_Class
    {
        public string name;
        public string surname;

        // конструктор с параметрами
        public Arbitary_Class(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        // конструктор без параметров по умолчанию
        public Arbitary_Class()
        {
            name = "ExampleName";
            surname = "ExampleSurname";
        }

        // добавление деструктора который будет удалять обьект класса 
        ~Arbitary_Class()
        {
            Console.WriteLine("Объект класса удален");
        }

        // метод вывода значений
        public void OutputData()
        {
            Console.Write("Введите своё имя: ");
            name = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            surname = Console.ReadLine();
        }
    }

}
