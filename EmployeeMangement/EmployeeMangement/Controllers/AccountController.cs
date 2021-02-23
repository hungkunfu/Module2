using EmployeeMangement.Models.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //[AcceptVerbs("GET", "Post)]
        public IActionResult Login(LoginModel model)
        {
            //check user is exist
            //if exist => dashboard
            //else show error
            if(model.Email == "khoa.nguyen@codegym.vn" && model.Password == "123456")
            {
                return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
            }
            return View();
        }
    }
}
