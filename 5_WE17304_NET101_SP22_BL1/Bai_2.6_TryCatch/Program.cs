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
        }
    }
}
