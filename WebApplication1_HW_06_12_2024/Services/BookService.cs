using WebApplication1_HW_06_12_2024.Data;
using WebApplication1_HW_06_12_2024.Interfaces;
using WebApplication1_HW_06_12_2024.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1_HW_06_12_2024.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreContext _context;

        public BookService(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books.Include(b => b.Comments).ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            return await _context.Books
                .Include(b => b.Comments)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddCommentAsync(int bookId, string userName, string text)
        {
            var comment = new Comment
            {
                BookId = bookId,
                UserName = userName,
                Text = text
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }
    }
}
