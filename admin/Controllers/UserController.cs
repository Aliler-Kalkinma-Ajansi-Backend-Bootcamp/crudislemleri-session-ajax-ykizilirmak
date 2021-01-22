using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            data.Service.UserService userService = new data.Service.UserService();
            var users = userService.GetAllUsers();
            return View(users);
        }

        public IActionResult Edit(int? id)
        {
            var user = new data.Model.TblUser();
            if (id > 0) 
            { 
                data.Service.UserService userService = new data.Service.UserService();
                user = userService.GetById(id.Value);
            }
            
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(data.Model.TblUser data)
        {
            var user = new data.Model.TblUser();
            data.Service.UserService userService = new data.Service.UserService();

            if (data.Id > 0)
            {
                userService.Update(data);
            }
            else 
            {
                userService.Insert(data);
            }

            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
            data.Service.UserService userService = new data.Service.UserService();
            userService.Delete(id);
            
            return RedirectToAction("Index");
        }

    }
}
