using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiptbachai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b,c;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập c: ");
            c = float.Parse(Console.ReadLine());


            float delta = b * b - 4 * a * c;
            if (a != 0)
            {
                if (delta > 0)
                {
                    Console.WriteLine("Phương trình có 2 nghiệm: ");
                    Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                    Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));

                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phương trình có nghiệm kép: ");
                    Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
                }
                else if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
            else
            {
                Console.WriteLine("Phương trình có 1 nghiệm duy nhất x = {0}", -c/b);
            }
        }
    }
}
