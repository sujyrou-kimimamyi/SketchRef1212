using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sketchref
{
    public class User
    {

        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _phone;

        public User(string name, 
                    string email, 
                    string password, 
                    string phone)
        {
            
            _name = name;
            _email = email;  
            _password = password;
            _phone = phone;

        }

        //propina
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }

        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }

    }

   
}
