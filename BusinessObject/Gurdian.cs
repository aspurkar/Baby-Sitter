using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{

    public class Gurdian
    {

    private string _email;
    private string _firstName; 
    private string _lstName; 
    private string _city; 
    private string _state;
    private string _password; 
    private byte[] _image;   
    private string _country; 
    private string _contactNo; 
    private string _about;


        public string email { get { return _email; } set { _email = value; } }


        public string firstName { get { return _firstName; } set { _firstName = value; } }


        public string lstName { get { return _lstName; } set { _lstName = value; } }




        public string city { get { return _city; } set { _city = value; } }


        public string state { get { return _state; } set { _state = value; } }


        public string password { get { return _password; } set { _password = value; } }


        public byte[] image { get { return _image; } set { _image = value; } }


        public string country { get { return _country; } set { _country = value; } }

        public string contactNo { get { return _contactNo; } set { _contactNo = value; } }

        public string about { get { return _about; } set { _about = value; } }

        

    }
}
