namespace WebApplication1_HW_06_12_2024.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
