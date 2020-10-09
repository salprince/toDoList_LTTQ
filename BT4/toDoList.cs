using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    public class toDoList
    {
        public List<String> userName { get; set; }
        public List<String> toDo { get; set; }
        public List<Boolean> checkBox { get; set; }

        public toDoList() 
        {
            toDo = new List<string>();
            checkBox = new List<bool>();
            userName = new List<string>();
        }
        public void import(String path)
        {
            //makes map to convert 'string' to 'bool' value
            var accounts = new Dictionary<string, Boolean>();
            accounts["True"] = true;
            toDo = new List<string>();
            checkBox = new List<bool>();
            userName = new List<string>();
            if (File.Exists(path))
            {
                String[] s = File.ReadAllLines(path);
                for (int i = 0; i < s.Length; i++)
                {
                    String[] s1 = s[i].Split(',');
                    if (s1.Length >= 3)
                    {
                        this.userName.Add(s1[0]);
                        this.toDo.Add(s1[1]);
                        this.checkBox.Add(accounts.ContainsKey(s1[2].Trim()));
                    }
                }
            }
        }
        public void export(String path,String data)
        {
            if (!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
            }
            File.AppendAllText(path, data);
            //File.WriteAllText();
        }
        public String toString()
        {
            String result = "";
            for (int i = 0; i < toDo.Count; i++)
                result +=userName[i]+ toDo[i] + " " + checkBox[i].ToString() + "\n";
            return result;
        }
    }
}
