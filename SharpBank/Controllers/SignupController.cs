using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharpBank.Models.Login;

namespace SharpBank.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendSignupData(SignupFormModel signupForm)
        {
            //TODO check for existing users in bank database and if the request is valid, create account, send validation
            // and show signup success
            return View();
        }
    }
}