using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public class AuthorL
    {
        public string nameAutor;
        public string surnameAutor;
        public int birthYear;

        public AuthorL(string nameAutor, string surnameAutor, int birthYear)
        {
            this.nameAutor = nameAutor;
            this.surnameAutor = surnameAutor;
            this.birthYear = birthYear;
        }
    }

    public class BookL
    {
        public string titleBook;
        public AuthorL AuthorL;
        public int yearPublished;

        public BookL(string titleBook, AuthorL author, int yearPublished)
        {
            this.titleBook = titleBook;
            AuthorL = author;
            this.yearPublished = yearPublished;
        }
    } 

    public class Library
    {
        private List<BookL> books = new List<BookL>(); // список книг
        public void AddBook()
        {
            Console.Write("Введите название книги: ");
            string titleBook = Console.ReadLine();
            Console.Write("Введите имя автора: ");
            string authorName = Console.ReadLine();
            Console.Write("Введите фамилию автора: ");
            string authorSurname = Console.ReadLine();
            Console.Write("Введите год рождения автора: ");
            int authorBirthYear = int.Parse(Console.ReadLine());
            Console.Write("Введите год выпуска книги: ");
            int yearPublished = int.Parse(Console.ReadLine());

            AuthorL author = new AuthorL(authorName, authorSurname, authorBirthYear);
            BookL newBook = new BookL(titleBook, author, yearPublished);
            books.Add(newBook);
            Console.WriteLine("Книга успешно добавлена в библиотеку");
            Console.ReadLine();
        }
        public void RemoveBook()
        {
            Console.Write("Введите название книги, которую хотите удалить: ");
            string titleDelete = Console.ReadLine();

            bool bookIS = false; // флаг для удаления книги
            if (books.Count > 0)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].titleBook == titleDelete)
                    {
                        books.RemoveAt(i);
                        Console.WriteLine("Книга удалена из библиотеки");
                        bookIS = true;
                        break;
                    }
                }

                if (!bookIS)
                {
                    Console.WriteLine("Книга с таким названием не найдена");
                }
            }
            else
            {
                Console.WriteLine("В списке нету книг");
            }
            Console.ReadLine();
        }
        public void FindBooksByYear() // метод нахождения книги по году выпуска
        {
            Console.Write("Введите год выпуска книги: ");
            int yearFind; // локальная переменная по вводу
            if (books.Count > 0)
            {
                if (int.TryParse(Console.ReadLine(), out yearFind))
                {
                    List<BookL> booksYear = books.Where(b => b.yearPublished == yearFind).ToList();

                    if (booksYear.Count > 0)
                    {
                        Console.WriteLine($"Найдены книги, выпущенные в {yearFind} году:");
                        foreach (var book in booksYear)
                        {
                            Console.WriteLine($"Название: {book.titleBook}, Автор: {book.AuthorL.nameAutor} {book.AuthorL.surnameAutor}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Книги с указанным годом выпуска не найдено");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод года. Введите число");
                }
            }
            else
            {
                Console.WriteLine("В списке нету книг");
            }
            Console.ReadLine();
        }
        public void OutputBooks()
        {
            if (books.Count > 0)
            {
                Console.WriteLine("Список оставшихся книг:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Название: {book.titleBook}, Автор: {book.AuthorL.nameAutor} {book.AuthorL.surnameAutor}, Год выпуска: {book.yearPublished}");
                }
            }
            else
            {
                Console.WriteLine("В списке нету книг");
            }
            Console.ReadLine();
        }
        public bool ExitCycle(string choiceNumberTemp)
        {
            if (choiceNumberTemp == "5")
            {
                return false;
            }
            return true;
        }
        public void OutputData()
        {
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("\t---Библиотека---");
                Console.WriteLine("Выберите номер нужной функции: " +
                    "\n1. Добавить книгу" +
                    "\n2. Удалить книгу" +
                    "\n3. Найти книгу по году выпуска" +
                    "\n4. Вывести все доступные книги" + 
                    "\n5. Для выхода из меню нажмите '5' ");

                string choiceNumber = Console.ReadLine();

                switch (choiceNumber)
                {
                    case "1":
                        Console.Clear();
                        AddBook();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        RemoveBook();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        FindBooksByYear();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        OutputBooks();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        continueLoop = ExitCycle(choiceNumber);
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
