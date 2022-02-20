using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiptbacnhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            string strA, strB;
            int A , B;
            double nghiem;


            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Giải phương trình Ax + B = 0");


            Console.Write("Nhập A:");
            strA = Console.ReadLine();
            Console.Write("Nhập B:");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại");
                return;
            }
            else
            {
                Console.WriteLine("Phương trình bạn vừa nhập là: {0}x+{1}=0", A, B);

                if(A == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm");
                }
                else if(B == 0)
                {
                    Console.WriteLine("Phương trình có nghiệm x = 0");


                }
                else 
                {
                    nghiem = (double)A / B; //ép kiểu double để hiện kq thập phân

                    Console.WriteLine("Phương trình có nghiệm x = {0}", nghiem);

                        }
            }
                Console.ReadLine();
            #end

        }
    }
}
