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
            
            Name = name;
            Email = email;  
            Password = password;
            Phone = phone;

        }

        //propina
        public string Name
        {
            set { 
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("vai tomar no cu ta errado fais direito ai");
                
                    _name = value; 
                }
            get { return _name; }
        }

        public int Id
        {
            set {_id = value; }
            get { return _id; }
        }

        public string Phone
        {
            set { 
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("vai tomar no cu ta errado fais direito ai");
                
                    _phone = value; 
                }
            get { return _phone; }
        }

        public string Password
        {
            set { 
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("vai tomar no cu ta errado fais direito ai");
                
                    _password = value; 
                }
            get { return _password; }
        }

        public string Email
        {
            set { 
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("vai tomar no cu ta errado fais direito ai");
                
                    _email = value; 
                }
            get { return _email; }
        }

    }

   
}
