using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_2
{
    class Employee
    {
        // Поля класса
        private string name;
        private byte age;
        private bool isValidAge;
        private string position;
        private decimal salaryPerMonth;

        // Метод для расчета годового дохода на основе месячной зарплаты
        public decimal CalculateAnnualIncome()
        {
            return salaryPerMonth * 12;
        }

        public void OutputData()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

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

            Console.Write("Введите должность: ");
            position = Console.ReadLine();

            Console.Write("Введите месячную зарплату: ");
            salaryPerMonth = decimal.Parse(Console.ReadLine());

            // Вывод информации о сотруднике
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Месячная зарплата: {salaryPerMonth}");

            // Расчет и вывод годового дохода
            decimal annualIncome = CalculateAnnualIncome();
            Console.WriteLine($"Годовой доход: {annualIncome}");

            // изменение месячной зарплаты и ее вывод
            Console.Write("Введите новую месячную зарплату: ");
            decimal newMonthlySalary = decimal.Parse(Console.ReadLine());

            salaryPerMonth = newMonthlySalary;
            Console.WriteLine($"Обновленная месячная зарплата: {salaryPerMonth}");

            // Расчет и вывод обновленного годового дохода
            annualIncome = CalculateAnnualIncome();
            Console.WriteLine($"Обновленный годовой доход: {annualIncome}");
            Console.ReadLine();

        }
    }

}
