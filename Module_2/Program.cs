using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); // обьект класса person 
            Inh_Poly inh_poly = new Inh_Poly(); // обьект класса "наследование и полиморфизм"
            Compozition compozition = new Compozition(); // обьект класса "композиции"
            Intf_Abst interface_abstract = new Intf_Abst(); // обьект класса интерфеса и абстаригирования
            TemperatureSensorRealization temperatureSensorRealization = new TemperatureSensorRealization();
            Employee employee = new Employee();
            Arbitary_Class arbitary_class = new Arbitary_Class();

            while (true)
            {
                // меню выбора
                Console.WriteLine("\t---Меню---");
                Console.WriteLine("1. Создание класса Person");
                Console.WriteLine("2. Наследование и полиморфизм");
                Console.WriteLine("3. Композиция");
                Console.WriteLine("4. Интерфейсы и абстрактные классы");
                Console.WriteLine("5. События");
                Console.WriteLine("---Задания по варианту 3---");
                Console.WriteLine("6. Создание класса 'Сотрудник' ");
                Console.WriteLine("7. Создать класс с двумя переменными");
                Console.WriteLine("8. Создание класса 'Библиотека'");
                

                string choiceNumber = Console.ReadLine();

                switch (choiceNumber)
                {
                    case "1":
                        Console.Clear();
                        person.SetInfo();
                        person.GetInfo();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        inh_poly.OutputData();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        compozition.OutputData();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        interface_abstract.DrawI();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        temperatureSensorRealization.Temperature();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        employee.OutputData(); 
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        arbitary_class.OutputData();
                        Console.Clear();
                        break;
                    case "8":
                        Console.Clear();

                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
