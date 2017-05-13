using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Sitter sitter = new Sitter();
              sitter.email="sdfghj@fgph.cvb";
              sitter.firstName = "Aditya";
              sitter.lstName = "Purkar";
              sitter.password = "123456";
              sitter.city = "Amravati";
              sitter.state = "MH";
              sitter.country = "India";
              sitter.salaryRange= "djnkjf";
              sitter.about ="klnjn knkl kkl";
              sitter.gender ="male";
              sitter.isMarried = true;
              sitter.birthDate = "fnkrff";
              sitter.age = 56;
              sitter.image = new Byte[0];
              sitter.contactNo = "123456789";

              SignUp s = new SignUp();

              s.sitterSignUp(sitter);
              */

            LoginVO l = new LoginVO();

            l.email = "aditya@gmail.com";
            l.password = "jdbf";

            SignIn s = new SignIn();
            UserDataVO user = s.checkPassword(l);

            System.Diagnostics.Debug.Write(user.type);
            System.Diagnostics.Debug.Write(user.Gmodel.firstName);
            System.Diagnostics.Debug.Write(user.Smodel.firstName);




        }
    }
}

