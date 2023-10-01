using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    class Author
    {
        public string name;
        public int birthYear;

        public Author(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
    }
    class Book
    {
        public string title;
        public int year;
        public Author author;

        public Book(string title, int year, Author author)
        {
            this.title = title;
            this.year = year;
            this.author = author;
        }
    }

    public class Compozition
    {
        public void OutputData()
        {
            // ввод имени автора 
            Console.Write("Введите имя 1 автора: ");
            string authorName1 = Console.ReadLine();
            // ввод года рождения автора
            Console.Write("Введите год рождения 1 автора: ");
            int authorBirthYear1 = Convert.ToInt32(Console.ReadLine());

            // ввод названия книги
            Console.Write("Введите название 1 книги: ");
            string bookTitle1 = Console.ReadLine();
            // ввод года выпуска книги
            Console.Write("Введите год выпуска 1 книги: ");
            int bookYear1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите имя 2 автора: ");
            string authorName2 = Console.ReadLine();
            Console.Write("Введите год рождения 2 автора: ");
            int authorBirthYear2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите название 2 книги: ");
            string bookTitle2 = Console.ReadLine();
            Console.Write("Введите год выпуска 2 книги: ");
            int bookYear2 = Convert.ToInt32(Console.ReadLine());

            Author author1 = new Author(authorName1, authorBirthYear1);
            Author author2 = new Author(authorName2, authorBirthYear2);

            Book book1 = new Book(bookTitle1, bookYear1, author1);
            Book book2 = new Book(bookTitle2, bookYear2, author2);

            Console.WriteLine($"Книга: {book1.title}, Год выпуска: {book1.year}, Автор: {book1.author.name}");
            Console.WriteLine($"Книга: {book2.title}, Год выпуска: {book2.year}, Автор: {book2.author.name}");
            Console.ReadLine();
        }
    }
}
