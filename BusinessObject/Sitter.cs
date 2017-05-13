using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Sitter
    {
        private string _email;
        private string _firstName;
        private string _lstName;
        private string _password;
        private string _city;
        private string _state;
        private string _country;
        private string _salaryRange;
        private string _about;
        private string _gender;
        private bool _isMarried;
        private string _birthDate;
        private int _age;
        private byte[] _image;
        private string _contactNo;

        public string email { get { return _email; } set { _email = value; } }
        public string firstName { get { return _firstName; } set { _firstName = value; } }
        public string lstName { get { return _lstName; } set { _lstName = value; } }
        public string city { get { return _city; } set { _city = value; } }
        public string state { get { return _state; } set { _state = value; } }
        public string password { get { return _password; } set { _password = value; } }
        public byte[] image { get { return _image; } set { _image = value; } }
        public string country { get { return _country; } set { _country = value; } }
        public string contactNo { get { return _contactNo; } set { _contactNo = value; } }
        public string salaryRange { get { return _salaryRange; } set { _salaryRange = value; } }
        public string about { get { return _about; } set { _about = value; } }
        public string gender { get { return _gender; } set { _gender = value; } }
        public bool isMarried { get { return _isMarried; } set { _isMarried = value; } }
        public string birthDate { get { return _birthDate; } set { _birthDate = value; } }
        public int age { get { return _age; } set { _age = value; } }

    }
}
