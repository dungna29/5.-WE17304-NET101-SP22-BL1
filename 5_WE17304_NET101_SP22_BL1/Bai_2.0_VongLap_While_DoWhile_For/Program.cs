using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._0_VongLap_While_DoWhile_For
{
    internal class Program
    { /*
         * Bài 2.0 Vòng lặp:
         *
         * Định nghĩa chung cho tất cả vòng lặp:
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * + Cách dùng: wh + tab
         *
         * + Công thức:
         *  while (true)
            {
                //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
            }
         */

        /*
        * Bài 2.1 Vòng lặp do..While khác với vòng lặp while đó là sẽ thực hiện hành động 1 lần kể cả khi while(False). Điều kiện kiện để chạy vòng lặp vẫn là While(true)
        *
        * Cách gõ: do + tab
        *
        * Công thức:
        *  do
           {
               //Thực hiện ít nhất 1 lần nếu While False             
           } while (false);
        */

        /*
         * Vòng lặp for
         *
         * Cách gõ: for + tab
         * Công thức:
         *  for (int i = 0; i < UPPER; i++)
            {
                //Thực hiện 1 hành động lặp lại 1 công việc nào đó.
            }
            int i = 0: Điểm bắt đầu của vòng lặp
            i < UPPER: Điều kiện để ngắt vòng lặp
            i++: Tăng i lên 1
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Cách sử dụng vòng lặp đúng:
             * 1. Điều kiện vòng lặp
             * 2. Bước nhẩy
             * 3. Điểm bắt đầu
             */
            //For = for + tab
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine("Tôi ko muốn mất 659K lần thứ " + i);
            // }

            //While = wh + tab
            // int i = 0;
            // while (i < 3)
            // {
            //     Console.WriteLine("Tôi ko muốn mất 659K lần thứ " + i);
            //     i++;
            // }

            //Do...While = do + tab
            int i = 0;
            do
            {
                Console.WriteLine("Tôi ko muốn mất 659K lần thứ " + i);
                i++;
            } while (i < 3);

            //Break: Dùng để ngắt vòng lặp và luôn theo 1 điều kiện nhất định.
            //Điều kiện vòng lặp 5 lần ngắt khi gặp j = 3
            for (int j = 0; j < 5; j++)
            {
                if (j == 3)
                {
                    break;
                }

                Console.WriteLine("Số thứ: " + j);
            }

            Console.WriteLine("=============");
            //ĐIều kiện vòng lặp 5 lần bỏ qua các số chẵn không in ra
            for (int j = 0; j < 5; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine("Số thứ: " + j);
                }
            }

            Console.WriteLine("=================");
            for (int j = 0; j < 5; j++)
            {
                if (j % 2==0)
                {
                    continue;
                }
                Console.WriteLine("Số thứ: " + j);
            }
        }
    }
}
