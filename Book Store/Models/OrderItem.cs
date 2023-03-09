using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class OrderItem
    {
        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrederId { get; set; }
        public int BookId { get; set; }

        public Orders Order { get; set; } = new Orders();
        public Books BookItem { get; set; } = new Books();
    }
}
