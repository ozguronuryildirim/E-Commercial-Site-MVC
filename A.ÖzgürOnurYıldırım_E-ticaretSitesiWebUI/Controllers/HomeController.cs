using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models.Entity;

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome | i.IsApproved).Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId

                }).ToList();


            return View(urunler);//buraya dikkat buradan sorun çıkabilir
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound(); // Veya uygun bir hata sayfasına yönlendirme
            }

            return View(product);
        }

        public ActionResult List(int? id)
        { 

            var urunler = _context.Products
                .Where(i => i.IsApproved).Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ??"2.jpg",
                    CategoryId = i.CategoryId

                }).AsQueryable();
            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);

            }
            return View(urunler.ToList());//buraya dikkat buradan sorun çıkabilir

        }
        

        public PartialViewResult GetCategories()
        {

            return PartialView(_context.Categories.ToList());
                       
        }
    }
}