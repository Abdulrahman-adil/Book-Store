using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; } = ""; // string.Empty;
        public string Isbn { get; set; } = "";
        public decimal Price { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? Image { get; set; }
        
        [InverseProperty("BookItem")]
        public List<OrderItem> BookItems { get; set; } = new List<OrderItem>();

        // Publisher
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; } = new Publisher();

        // Author 
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; } = new Author();

        // Type/Category
        [ForeignKey("BookType")]
        public int TypeId { get; set; }
        public Type BookType { get; set; } = new Type();

    }
}
