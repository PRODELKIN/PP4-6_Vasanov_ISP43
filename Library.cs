using System;
using System.Collections.Generic;

namespace LibraryApp
{
    /// <summary>
    /// хранит книги, выдаёт книги, возвращает книги
    /// </summary>
    public class Library
    {
        private List<Book> books = new List<Book>();

        /// <summary>
        /// добавление книги
        /// </summary>
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        /// <summary>
        /// поиск книги по ID
        /// </summary>
        public Book FindBook(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }

            return null;
        }

        /// <summary>
        /// выдача книги
        /// </summary>
        public void BorrowBook(int id)
        {
            Book book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine("Ошибка: книга не найдена.");
                return;
            }

            if (book.IsAvailable == false)
            {
                Console.WriteLine("Ошибка: книга уже выдана.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine("Книга выдана: " + book.Title);
        }

        /// <summary>
        /// возврат книги
        /// </summary>
        public void ReturnBook(int id)
        {
            Book book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine("Ошибка: книга не найдена.");
                return;
            }

            if (book.IsAvailable == true)
            {
                Console.WriteLine("Ошибка: книга не была выдана.");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine("Книга возвращена: " + book.Title);
        }
    }
}

