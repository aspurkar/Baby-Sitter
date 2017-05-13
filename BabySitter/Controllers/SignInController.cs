using BabySitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabySitter.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        public ActionResult SignInShow()
        {

            return View("Login");
        }

        [HttpPost]
        public ActionResult Check(LoginVO model)
        {


            return View("ack");
        }



    }
}