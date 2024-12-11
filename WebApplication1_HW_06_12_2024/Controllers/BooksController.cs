using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1_HW_06_12_2024.Data;
using WebApplication1_HW_06_12_2024.Interfaces;
using WebApplication1_HW_06_12_2024.Models;

namespace WebApplication1_HW_06_12_2024.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllBooksAsync();
            return View(books);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int bookId, string userName, string text)
        {
            await _bookService.AddCommentAsync(bookId, userName, text);
            return RedirectToAction("Details", new { id = bookId });
        }
    }
}
