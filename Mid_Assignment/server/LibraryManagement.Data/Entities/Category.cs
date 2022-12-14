using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Entities
{
    public class Category : BaseEntity<int>
    {
        [Required, MaxLength(50)]
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}