using BusinessObject;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslogic
{
    class Program
    {
        static void Main(string[] args)
        {

            Sitter sitter = new Sitter();
            sitter.email = "sdfhj@fgh.cvb";
            sitter.firstName = "Aditya";
            sitter.lstName = "Purkar";
            sitter.password = "123456";
            sitter.city = "Amravati";
            sitter.state = "MH";
            sitter.country = "India";
            sitter.salaryRange = "djnkjf";
            sitter.about = "klnjn knkl kkl";
            sitter.gender = "male";
            sitter.isMarried = true;
            sitter.birthDate = "fnkrff";
            sitter.age = 56;
            sitter.image = new Byte[0];
            sitter.contactNo = "123456789";

            SitterOpr s = new SitterOpr();
            s.signUp(sitter);

        }
    }
}
