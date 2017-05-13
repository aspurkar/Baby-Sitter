using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataLayer;

namespace Businesslogic
{
    public class SitterOpr : ISitterOpr
    {
        public void signUp(Sitter model)
        {
            ISignUp dao = new SignUp();

            dao.sitterSignUp(model);


        }
    }
}
