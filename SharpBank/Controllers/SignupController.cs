using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharpBank.Models;
using SharpBank.Models.Login;

namespace SharpBank.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(SignupFormModel signupForm)
        {
            //TODO check for existing users in bank database and if the request is valid, create account, send validation
            // and show signup success
            ErrorViewModel error = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                ErrorMessage = "Signup failed due to ..."
            };
            ViewBag.Message = error;
            return View();
        }
    }
}