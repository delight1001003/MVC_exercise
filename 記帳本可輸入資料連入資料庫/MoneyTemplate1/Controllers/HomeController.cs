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
            return View();
        }

        private SkillTreeModels db = new SkillTreeModels();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountBook)
        {
            

            if (ModelState.IsValid)
            {
                accountBook.Id = Guid.NewGuid();
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountBook);
        }


        public ActionResult add_data()
        {
            var db = new SkillTreeModels();
            var list = new List<MyClass>();

            foreach (var data in db.AccountBook)
            {
                var myClassData = new MyClass();

                if (data.Categoryyy == 0)
                {
                    myClassData.Type = "收入";
                }
                else
                {
                    myClassData.Type = "支出";
                }


                myClassData.Time = data.Dateee;

                myClassData.Money = data.Amounttt;

                list.Add(myClassData);
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