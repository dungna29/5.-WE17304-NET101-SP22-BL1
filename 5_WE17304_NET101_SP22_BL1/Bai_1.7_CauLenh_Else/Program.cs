using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._7_CauLenh_Else
{
    internal class Program
    {
        /*
        * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
        * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
        *
        * Cấu trúc: 
        * if (true)
           {
               Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
           }
           else
           {
               Nếu không thỏa mãn IF thì mặc định là vào ELSE
           }
        */
        static void Main(string[] args)
        {
            if (true)
            {

            }
            else
            {
                //Thực hiện khi không thỏa mãn if
            }
            /*
             * Viết 1 chương trình cho người dùng nhập điểm GPA
             * 9 - 10 = Xuất Sắc
             * 8 - 9 = Giỏi
             * 6 - 8 = Khá
             * 5 - 6 = TB
             * 0 - 4 = Học lại
             * Không sử dụng Else IF - Ko dùng return
             * Chỉ dùng IF Else
             */
            double diemGPACsharp;
            Console.WriteLine("Mời bạn nhập điểm: ");
            diemGPACsharp = Convert.ToDouble(Console.ReadLine());
            if (diemGPACsharp >=9 && diemGPACsharp <=10)
            {
                Console.WriteLine("Xuất sắc");
            }
            else
            {
                if (diemGPACsharp >= 8 && diemGPACsharp < 9)
                {
                    Console.WriteLine("giỏi");
                }
                else
                {
                    if (diemGPACsharp >=6 && diemGPACsharp < 8)
                    {
                        Console.WriteLine("giỏi");
                    }
                    else
                    {
                        if (diemGPACsharp >= 5 && diemGPACsharp < 6)
                        {
                            Console.WriteLine("TB");
                        }
                        else
                        {
                            Console.WriteLine("Chúc mừng bạn mất 659K");
                        }
                    }
                }
            }
        }
    }
}
