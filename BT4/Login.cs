using System;
using System.Collections.Generic;

namespace BT4
{
    class Login
    {
        public String UserName;
        public String Password;
        public Login() { }
        public Login(String name, String pass)
        {
            UserName = name;
            Password = pass;
        }
        public Login(String full)
        {
            List<String> element = new List<String>();
            element.AddRange(full.Split(','));
            UserName = element[0];
            Password = element[1];
        }
        public String toString()
        {
            return ($"{UserName},{Password}");
        }
    }
}
