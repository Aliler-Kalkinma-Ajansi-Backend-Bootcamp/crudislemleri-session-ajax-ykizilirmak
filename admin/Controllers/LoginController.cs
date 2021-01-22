using admin.Filters;
using admin.Models;
using data.Model;
using data.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace admin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private bool SignIn(TblUser user)
        {
            bool result = false;

            LoginControl service = new LoginControl();                        // db tarafı 
            var UserId = service.Login(user.Username, user.Password);         // db tarafı
            HttpContext.Session.SetString("Id", UserId.ToString());          // LoginLog a get etceğimiz kısım
            if (UserId>0)
            {
                TempData["Name"] = user.Username;
                result = true;
            }
            

                return result;
        }

        [HttpPost]
        public IActionResult Index(TblUser user)
        {
           

            bool sign = SignIn(user);
            if (sign == true)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


    }
}
