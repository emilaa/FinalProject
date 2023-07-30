using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id is null)
            {
                ViewBag.count = await _context.Products.Where(m => !m.IsDeleted).CountAsync();

                IEnumerable<PageHeader> pageHeaders = await _context.PageHeaders.Where(m => !m.IsDeleted).ToListAsync();

                IEnumerable<Product> products = await _context.Products
                    .Where(m => !m.IsDeleted)
                    .Include(m => m.ProductImages)
                    .Include(m => m.ProductSubCategories)
                    .ThenInclude(m => m.SubCategory)
                    .Take(4)
                    .OrderByDescending(m => m.Id)
                    .ToListAsync();

                IEnumerable<SubCategory> subCategories = await _context.SubCategories
                    .Where(m => !m.IsDeleted)
                    .ToListAsync();

                ShopVM model = new ShopVM
                {
                    PageHeaders = pageHeaders,
                    Products = products,
                    SubCategories = subCategories
                };

                return View(model);
            }
            else
            {
                ViewBag.count = await _context.Products.Where(m => !m.IsDeleted).CountAsync();

                IEnumerable<PageHeader> pageHeaders = await _context.PageHeaders.Where(m => !m.IsDeleted).ToListAsync();

                IEnumerable<Product> products = await _context.Products
                    .Where(m => !m.IsDeleted && m.ProductSubCategories.Where(n => n.SubCategoryId == id).FirstOrDefault().SubCategoryId == id)
                    .Include(m => m.ProductImages)
                    .Include(m => m.ProductSubCategories)
                    .ThenInclude(m => m.SubCategory)
                    .Take(4)
                    .OrderByDescending(m => m.Id)
                    .ToListAsync();

                IEnumerable<SubCategory> subCategories = await _context.SubCategories
                    .Where(m => !m.IsDeleted)
                    .ToListAsync();

                ShopVM model = new ShopVM
                {
                    PageHeaders = pageHeaders,
                    Products = products,
                    SubCategories = subCategories,
                };

                return View(model);
            }
        }

        public async Task<IActionResult> ShowMore(int skip)
        {
            IEnumerable<Product> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Skip(skip)
                .Take(4)
                .ToListAsync();

            ShopVM model = new ShopVM
            {
                Products = products
            };

            return PartialView("_ProductsPartial", model);
        }

        public IActionResult Search(string search)
        {
            List<Product> searchProduct = _context.Products.Include(m => m.ProductImages).Where(m => m.Name.ToLower().Contains(search.ToLower()) && !m.IsDeleted).ToList();

            ShopVM model = new ShopVM
            {
                Products = searchProduct
            };

            return PartialView("_SearchProductPartial", model);
        }
    }
}
