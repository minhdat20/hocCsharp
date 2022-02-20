using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case cơ bản nhập j
            #region
            /* string strj;
             int j;

             Console.Write("Nhap j: ");
             strj = Console.ReadLine(); 
             j = int.Parse(strj);   

             switch (j)
             {
                 case 0:
                     Console.WriteLine("j=0");
                     break;
                 case 1:
                     Console.WriteLine("j=1");
                     break;
                 case 2:
                     Console.WriteLine("j=2");
                     break;
                 case 3:
                     Console.WriteLine("j=3");
                     break;
                 default:
                     Console.WriteLine("moi gia tri khac cua j se vao default");
                     break ; 
             }
     Console.ReadKey();*/
            #endregion
            //tìm can chi (2022 = Nhâm Dần)
            #region
            int Nam;
            string Can = "", Chi = "" ;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập năm: ");
            Nam =int.Parse(Console.ReadLine());
           

            switch (Nam%10)
            {
                case 0:
                    Can = "Canh";
                    break;
                case 1:
                    Can = "Tân";
                    break;
                case 2:
                    Can = "Nhâm";
                    break;
                case 3:
                    Can = "Quý";
                    break ;
                case 4:
                    Can = "Giáp";
                    break;
                case 5:
                    Can = "Ất";
                    break;
                case 6:
                    Can = "Bính";
                    break;
                case 7:
                    Can = "Tân";
                    break;
                case 8:
                    Can = "Mậu";
                    break;
                case 9:
                    Can = "Kỷ";
                    break;
               
            }
            switch (Nam%12)
            {
                case 0:
                    Chi = "Thân";
                    break;
                case 1:
                    Chi = "Dậu";
                    break;
                case 2:
                    Chi = "Tuất";
                    break;
                case 3:
                    Chi = "Hợi";
                    break;
                case 4:
                    Chi = "Tý";
                    break;
                case 5:
                    Chi = "Sửu";
                    break;
                case 6:
                    Chi = "Dần";
                    break;
                case 7:
                    Chi = "Mão";
                    break;
                case 8:
                    Chi = "Thìn";
                    break;
                case 9:
                    Chi = "Tỵ";
                    break;
                case 10:
                    Chi = "Ngọ";
                    break;
                case 11:
                    Chi = "Mùi";
                    break;
            }
            Console.WriteLine("Năm {0}: {1} {2}", Nam, Can, Chi);
            if (Nam == 2022)
            {
                Console.WriteLine("Hiện tại");
            }
            else if (Nam < 2022)
            {
                Console.WriteLine("Quá khứ");
            }
            else
            {
                Console.WriteLine("Tương lai");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
