using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("jacek");
            list.Add("wacek");
            list.Add("placek");
            list.Add("gacek");
            list.Add("pałko");
            FileHandler.Save("C:\\Users\\ozzy\\Desktop\\file.txt", list);
            foreach(string item in FileHandler.Read("C:\\Users\\ozzy\\Desktop\\file.txt"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
