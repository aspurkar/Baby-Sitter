using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserDataVO
    {
        private int _type;

        private Sitter _Smodel;

        private Gurdian _Gmodel;

        public int type { get { return _type; }
            set { _type = value; } }

        public Sitter Smodel
        {
            get { return _Smodel; }
            set { _Smodel = value; }
        }

        public Gurdian Gmodel
        {
            get { return _Gmodel; }
            set { _Gmodel = value; }
        }

    }
}
