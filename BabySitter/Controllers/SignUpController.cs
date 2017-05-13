using System.Web.Mvc;
using DataLayer;
using BabySitter.Models;
using System;
using Businesslogic;

namespace BabySitter.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp

        [HttpPost]
        public ActionResult GurdianSign(Gurdian g)
        {

            BusinessObject.Gurdian gurdObj = new BusinessObject.Gurdian();

            gurdObj.about = g.about;
            
            gurdObj.contactNo = g.contactNo;

            gurdObj.country = g.country;

            gurdObj.email = g.email;

            gurdObj.firstName = g.firstName;

            gurdObj.image = new Byte[10]; 

            gurdObj.lstName = g.lstName;

            gurdObj.password = g.password.GetHashCode().ToString().ToLower().Trim();

            gurdObj.state = g.state;

            gurdObj.city = g.city;





            IGurdianOpr BL = new GurdianOpr();

            BL.signUp(gurdObj);

            
            return View("ack");
        }
        
        [HttpGet]
        public ActionResult GurdianSignShow()
        {
            return View("sign");
        }

        [HttpGet]
        public ActionResult SitterSignShow()
        {
            return View("signSitter");
        }

        [HttpPost]
        public ActionResult SitterSign(Sitter s)
        {

            BusinessObject.Sitter sitter = new BusinessObject.Sitter();
            sitter.email = s.email;
            sitter.firstName = s.firstName;
            sitter.lstName = s.lstName;
            sitter.password = s.password;
            sitter.city = s.city;
            sitter.state = s.state;
            sitter.country = s.country;
            sitter.salaryRange = s.salaryRange;
            sitter.about = s.about;
            sitter.gender = s.gender;
            sitter.isMarried = s.isMarried;
            sitter.birthDate = s.birthDate;
            sitter.age = 56;
      sitter.image = new Byte[0];
            sitter.contactNo = s.contactNo;





            ISitterOpr BL = new SitterOpr();

            BL.signUp(sitter);


            return View("ack");
        }



    }
}