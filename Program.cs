using System;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book { Id = 1, Title = "Властелин колец", Author = "Джон Толкин" });
            library.AddBook(new Book { Id = 2, Title = "Сияние", Author = "Стивен Кинг" });
            library.AddBook(new Book { Id = 3, Title = "Война и мир", Author = "Лев Толстой" });
            library.ReturnBook(1);

            Book book = library.FindBook(1);
            Console.WriteLine("Найдена книга: " + book.Title + ", автор: " + book.Author);
            Console.WriteLine("Доступна: " + book.IsAvailable);

            library.BorrowBook(1);
            Console.WriteLine("Доступна после выдачи: " + library.FindBook(1).IsAvailable);

            library.ReturnBook(1);
            Console.WriteLine("Доступна после возврата: " + library.FindBook(1).IsAvailable);

            library.BorrowBook(2);
            Console.WriteLine("Доступна вторая книга: " + library.FindBook(2).IsAvailable);
        }
    }
}
