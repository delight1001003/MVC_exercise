using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {            
            return View();
        }


        
        [HttpPost]
        public ActionResult Login(LoginViewModel pageData)
        {
            
            
                if (pageData.Account == "skill" && pageData.Password == "tree")
                {
                    pageData.Message = "登入成功";

                        //$"您使用{pageData.Account}登入成功。";
                }
                else
                {
                    pageData.Message = "登入失敗";
                        //$"您使用{pageData.Account}登入失敗。";
                }

            
            return View(pageData);
        }
    }
}