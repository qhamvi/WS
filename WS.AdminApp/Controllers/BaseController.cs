﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WS.AdminApp.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //check
            var sessions = context.HttpContext.Session.GetString("Token");
            if(sessions is null)
            {
                context.Result = new RedirectToActionResult("Index", "Login",null);
            }    
            base.OnActionExecuting(context);
        }
    }
}
