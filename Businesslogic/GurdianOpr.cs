using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataLayer;

namespace Businesslogic
{
    public class GurdianOpr : IGurdianOpr
    {
        public void signUp(Gurdian model)
        {
            ISignUp dao = new SignUp();
            dao.gurdianSignUp(model);

        }

    }
}
