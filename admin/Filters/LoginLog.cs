using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using data.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace admin.Filters
{
    public class LoginLog:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var logindata = context.HttpContext.Session.GetString("Id");
            //ekranda hoş geldiniz ...  yazdır
            if (logindata == null || Int32.Parse(logindata) <= 0)
            {
                context.Result = new RedirectResult("~/Login/Index");
            }
           
            

            base.OnActionExecuting(context);
        }



        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //Action sonunda işlem yapar.
            base.OnActionExecuted(context);
        }

    }
}
