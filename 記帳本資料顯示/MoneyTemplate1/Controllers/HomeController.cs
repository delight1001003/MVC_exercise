using MoneyTemplate1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyTemplate1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var list = new List<MyClass>();
            MyClass model;
            var random = new Random();

            for (int i = 0; i<200; i++)
            {
                model = new MyClass();

                //用亂數給 Type 內容
                int tempType = random.Next(2);
                if ( tempType == 0 )
                {
                    model.Type = "收入";
                }
                else
                {
                    model.Type = "支出";
                }              

                //用亂數給 Time 內容 (時間的range為5年 → 365天 * 5 )
                model.Time = DateTime.Now.AddDays(random.Next(1826));

                //用亂數給 Money 內容
                model.Money = random.Next(50001);
               

                list.Add(model);
            }
            

            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}