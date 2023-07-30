using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using Online_Shop___BackEnd.ViewModels.BasketViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProductDetailController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserId = user.Id;
            }

            Product product = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Include(m => m.ProductComents)
                .ThenInclude(m => m.AppUser)
                .FirstOrDefaultAsync();

            ProductSubCategory productSubCategory = await _context.ProductSubCategories
                .Where(n => n.ProductId == id && n.SubCategory.CategoryId == 2)
                .Include(n => n.SubCategory)
                .FirstOrDefaultAsync();

            IEnumerable<ProductComent> comments = await _context.ProductComents.Where(m => !m.IsDeleted && m.ProductId == id).ToListAsync();

            SubCategory subCategory = productSubCategory.SubCategory;

            ShopVM model = new ShopVM
            {
                Product = product,
                SubCategory = subCategory,
                Comment = new ProductComent(),
                Comments = comments
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(string commentMessage, int productId)
        {
            AppUser user = null;

            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            else
            {
                RedirectToAction("Login", "Account");
            }

            ViewBag.UserId = user.Id;

            ProductComent comment = new ProductComent();
            comment.ProductId = productId;
            comment.AppUserId = user.Id;
            comment.Content = commentMessage;
            comment.CreateDate = DateTime.Now;

            List<ProductComent> comments = new List<ProductComent>();
            comments.Add(comment);

            ShopVM model = new ShopVM()
            {
                Comments = comments
            };

            await _context.ProductComents.AddAsync(comment);
            await _context.SaveChangesAsync();

            return PartialView("_CommentPartial", model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteComment(int id)
        {
            ProductComent comment = await _context.ProductComents.FirstOrDefaultAsync(m => m.Id == id);

            _context.ProductComents.Remove(comment);
            await _context.SaveChangesAsync();

            return Ok();
        }










        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveComment(int id)
        {
            ProductComent comment = await _context.ProductComents.FirstOrDefaultAsync(m => m.Id == id);
            comment.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = comment.ProductId });
        }

        [HttpPost]
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id is null) return BadRequest();

            var dbProduct = await GetProductById(id);

            if (dbProduct == null) return NotFound();

            List<BasketVM> basket = GetBasket();

            UpdateBasket(basket, dbProduct.Id);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            return Ok();
        }

        private void UpdateBasket(List<BasketVM> basket, int id)
        {
            BasketVM existProduct = basket.FirstOrDefault(m => m.Id == id);

            if (existProduct == null)
            {
                basket.Add(new BasketVM
                {
                    Id = id,
                    Count = 1
                });
            }
            else
            {
                existProduct.Count++;
            }
        }

        private async Task<Product> GetProductById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }


        private List<BasketVM> GetBasket()
        {
            List<BasketVM> basket;

            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }

            return basket;
        }
    }
}
