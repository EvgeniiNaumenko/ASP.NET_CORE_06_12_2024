namespace WebApplication1_HW_06_12_2024.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
