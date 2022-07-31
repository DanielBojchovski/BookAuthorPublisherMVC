using BookAuthorPublisherMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAuthorPublisherMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBooks = await _context.Books.Include(n => n.Publisher).OrderBy(n => n.Name).ToListAsync();
            return View(allBooks);
        }
    }
}
