namespace LibraryManagement.Data.Entities
{
    public class BookCategory : BaseEntity<int>
    {
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}