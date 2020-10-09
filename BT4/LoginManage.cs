using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class LoginManage
    {
        public List<Login> list;
        public LoginManage()
        {
            list = new List<Login>();
        }
        public List<Login> importData(String path)
        {
            List<Login> listSV = new List<Login>();
            if (File.Exists(path))
            {
                String[] s = File.ReadAllLines(path);
                for (int i = 0; i < s.Length; i++)
                {
                    Login a = new Login(s[i]);
                    listSV.Add(a);
                }
            }
            return listSV;
        }
        public void exportData(String path)
        {
            if (!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
            }
            File.WriteAllText(path, this.toString());
        }
        public String toString()
        {
            String result = "";
            if (list != null)
            {
                for (int i = 0; i < this.list.Count - 1; i++)
                    result += list[i].toString() + "\n";
                result += list[list.Count - 1].toString();
            }
            return result;
        }
        public String find(String findingKeyWord)
        {
            String result = "***";
            if (list != null)
            {
                for (int i = 0; i < this.list.Count; i++)
                    if (list[i].UserName.Equals(findingKeyWord))
                    {
                        result = list[i].Password + "\n";
                        break;
                    }
            }
            return result;
        }
    }
}
