using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ten = "Nguyen Minh";
            bool ktraten = ten == "Nguyen Minh Dat"? true : false;

            if(ktraten)
            {
                Console.WriteLine("dung roi");
            }
            else
            {
                Console.WriteLine("sai roi");
            }
        }
    }
}
