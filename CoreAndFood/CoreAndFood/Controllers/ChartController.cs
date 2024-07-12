using CoreAndFood.Data;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(Prolist());
        }
        public List<Class1> Prolist()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                proname = "Computer",
                stock = 150

            }) ;cs.Add(new Class1()
            {
                proname = "Lcd",
                stock = 75

            }) ;cs.Add(new Class1()
            {
                proname = "Usb Disk",
                stock = 220

            }) ;
            return cs;
        }

        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }
        public List<Class2> FoodList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new Class2()
                {
                    FoodName = x.Name,
                    stock = x.stock
                }).ToList();
            } return cs2;
        }
         
        public IActionResult Statistics()
        {
            Context c = new Context();
            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;

            var foid = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.ID).FirstOrDefault();

            var deger3 = c.Foods.Where(x => x.CategoryID == foid).Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Foods.Where(x => x.CategoryID == 2).Count();
            ViewBag.d4 = deger4;

            var deger5 = c.Foods.Sum(x => x.stock);
            ViewBag.d5 = deger5;

            var deger6 = c.Foods.Where(x => x.CategoryID == c.Categories.Where
            (y => y.CategoryName == "Legumes").Select(z => z.ID).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;

            var deger7 = c.Foods.OrderByDescending(x => x.stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d8 = deger8;
            return View();
        }
    }
}
