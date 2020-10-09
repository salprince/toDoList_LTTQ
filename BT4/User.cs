using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class User
    {
        public String name { get; set; }
        public String pass { get; set; }
        public User(String s) 
        {
            List<String> element = new List<String>();
            name = element[0];
            pass= element[1];
        }        
    }
}
