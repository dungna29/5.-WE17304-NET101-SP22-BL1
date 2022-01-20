using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._6_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Trong lúc lập trình thì không đóng try catch
             * 2. Chỉ đóng try catch: khi nộp bài, đi bảo vệ các môn dự án, khi bàn giao sản phẩm cho Tester, khi đóng gói sp cho khách hàng.
             */

            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                int a;
                Console.Write("Mời bạn nhập số nguyên: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);
            }
            catch (Exception)
            {
            
                Console.WriteLine("Bạn không nhập số nguyên");

            }
            Console.WriteLine("Kết thúc chương trình");

            int k1, k2;
            Console.WriteLine("Mời bạn nhập khoảng 1: ");
            k1 = Convert.ToInt32(Console.ReadLine()); //8
            Console.WriteLine("Mời bạn nhập khoảng 2: ");
            k2 = Convert.ToInt32(Console.ReadLine()); //5

            for (int i = Math.Min(k1,k2); i < Math.Max(k1, k2); i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
            }
           
        }
    }
}
