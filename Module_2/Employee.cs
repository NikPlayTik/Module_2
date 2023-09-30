using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Методы для получения и установки значений полей
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public decimal GetSalaryPerMonth()
        {
            return salaryPerMonth;
        }

        public void SetSalaryPerMonth(decimal salary)
        {
            this.salaryPerMonth = salary;
        }

        // Метод для расчета годового дохода на основе месячной зарплаты
        public decimal CalculateAnnualIncome()
        {
            return salaryPerMonth * 12;
        }

        public void OutputData()
        {
            // Ввод данных с клавиатуры
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

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
            string position = Console.ReadLine();

            Console.Write("Введите месячную зарплату: ");
            decimal monthlySalary = decimal.Parse(Console.ReadLine());

            // Создание объекта сотрудника
            Employee employee = new Employee();

            // Вывод информации о сотруднике
            Console.WriteLine($"Имя: {employee.GetName()}");
            Console.WriteLine($"Возраст: {employee.GetAge()}");
            Console.WriteLine($"Должность: {employee.GetPosition()}");
            Console.WriteLine($"Месячная зарплата: {employee.GetSalaryPerMonth()}");

            // Расчет и вывод годового дохода
            decimal annualIncome = employee.CalculateAnnualIncome();
            Console.WriteLine($"Годовой доход: {annualIncome}");

            // изменение месячной зарплаты и ее вывод
            Console.Write("Введите новую месячную зарплату: ");
            decimal newMonthlySalary = decimal.Parse(Console.ReadLine());

            employee.SetSalaryPerMonth(newMonthlySalary);
            Console.WriteLine($"Обновленная месячная зарплата: {employee.GetSalaryPerMonth()}");

            // Расчет и вывод обновленного годового дохода
            annualIncome = employee.CalculateAnnualIncome();
            Console.WriteLine($"Обновленный годовой доход: {annualIncome}");
        }
    }

}
