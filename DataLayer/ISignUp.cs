using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessObject;

namespace DataLayer
{
   public interface ISignUp
    {
        int sitterSignUp(Sitter sitter);

        int gurdianSignUp(Gurdian gurdian);

    }
}
