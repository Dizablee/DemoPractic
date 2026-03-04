using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class User
    {
        public string role { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public User(string role_, string name_, string login_, string password_)
        {
            role = role_;
            name = name_;
            login = login_;
            password = password_;
        }
    }
}
