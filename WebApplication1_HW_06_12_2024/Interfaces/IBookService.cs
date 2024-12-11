using WebApplication1_HW_06_12_2024.Models;

namespace WebApplication1_HW_06_12_2024.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book?> GetBookByIdAsync(int id);
        Task AddCommentAsync(int bookId, string userName, string text);
    }
}
