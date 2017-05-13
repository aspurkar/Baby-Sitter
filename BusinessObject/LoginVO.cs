using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class LoginVO
    {
    private string _email; 
    private string _password;

        public string email { get {

                return _email;

            } set {

                _email = value;

            } }


        public string password
        {
            get
            {

                return _password;

            }
            set
            {

                _password = value;

            }
        }




    }
}
