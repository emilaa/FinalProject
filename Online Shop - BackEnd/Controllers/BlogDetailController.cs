using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BlogDetailController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Blog blog = await _context.Blogs
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.BlogImages)
                .Include(m => m.BlogComments)
                .FirstOrDefaultAsync();

            IEnumerable<BlogComment> comments = await _context.BlogComments.Where(m => !m.IsDeleted && m.BlogId == id).ToListAsync();

                BlogVM model = new BlogVM
                {
                    Blog = blog,
                    BlogComment = new BlogComment(),
                    BlogComments = comments
                };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(BlogComment comment)
        {
            Blog blog = await _context.Blogs
               .Where(m => !m.IsDeleted && m.Id == comment.BlogId)
               .Include(m => m.BlogImages)
               .Include(m => m.BlogComments)
               .ThenInclude(m => m.AppUser)
            .FirstOrDefaultAsync();

            AppUser user = await _userManager.GetUserAsync(User);

            Blog blogImage = await _context.Blogs
                 .Include(m => m.BlogImages)
                .FirstOrDefaultAsync(m => m.Id == comment.BlogId);

            comment.AppUser = user;
            comment.AppUserId = user.Id;
            comment.CreateDate = DateTime.Now;
            comment.Blog = blog;

            await _context.BlogComments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = blog.Id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveComment(int id)
        {
            BlogComment comment = await _context.BlogComments.FirstOrDefaultAsync(m => m.Id == id);
            comment.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = comment.BlogId });
        }
    }
}
