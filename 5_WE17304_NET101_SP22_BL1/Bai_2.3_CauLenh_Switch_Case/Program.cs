using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._3_CauLenh_Switch_Case
{
    internal class Program
    {
        /*
        * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
        *
        * Công thức: sw + tab
        *
        *  switch (<Biểu thức>)
           {
               case <giá trị 1>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break; 
               case <giá trị 2>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break;
               .......
               case <giá trị n>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break;
               default:
                   Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                   break;
           }
        */
        static void Main(string[] args)
        {
            /*
             *  Xây dựng menu chọn chức năng bao gồm cả vòng lặp
             *
             */
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string choice;
            do
            {
                Console.WriteLine("Chương trình chọn Vaccine tiêm");
                Console.WriteLine("1. Vaccine VN");
                Console.WriteLine("2. Vaccine Cuba");
                Console.WriteLine("3. Vaccine Nga");
                Console.WriteLine("4. Vaccine Mỹ");
                Console.WriteLine("5. Thoát");
                Console.Write("Mời bạn chọn Vaccine để tiêm: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hiện nay đang phát triển chưa tiêm được");
                        break;
                    case "2":
                        Console.WriteLine("Hiện nay đang hết hàng");
                        break;
                    case "3":
                        Console.WriteLine("Bạn vui lòng đưa tay lên để tiêm");
                        break;
                    case "4":
                        Console.WriteLine("Hiện nay đang hết hàng");
                        break;
                    case "5":
                        Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ");
                        break;
                    default:
                        Console.WriteLine("Vaccine bạn chọn không tồn tại");
                        break;
                } 
            } while (choice!="5");

        }
    }
}
