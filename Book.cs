namespace LibraryApp
{
    /// <summary>
    /// книга в библиотеке
    /// </summary>
    public class Book
    {
        /// <summary>
        /// ID книги
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// название книги
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// автор книги
        /// </summary>
        public string Author { get; set; } = "";

        /// <summary>
        /// доступность книги
        /// </summary>
        public bool IsAvailable { get; set; } = true;
    }
}
