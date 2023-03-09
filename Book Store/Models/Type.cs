namespace Book_Store.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Books> Books { get; set; } = new List<Books>();
    }
}
