using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class QuanLy
    {
        public List<User> list { get; set; }
        public List<User> importData(String path)
        {
            List<User> listSV = new List<User>();
            if (File.Exists(path))
            {
                String[] s = File.ReadAllLines(path);
                for (int i = 0; i < s.Length; i++)
                {
                    User a = new User(s[i]);
                    listSV.Add(a);
                }
            }
            return listSV;
        }

    }
}
