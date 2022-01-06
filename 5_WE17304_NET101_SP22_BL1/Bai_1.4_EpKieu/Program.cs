using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._4_EpKieu
{
    internal class Program
    {
        /*
        * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
        *
        * Công thức ép kiểu tường minh:
        *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
        *
        * P2: Ép kiểu từ string về số
        *  + Phương thức Parse()
        *  + Lớp Convert()
        */
        static void Main(string[] args)
        {
            //Hỗ trợ hiển thị tiếng việt
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string a,b,c;
            Console.WriteLine("Mời bạn nhập a: ");
            a = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập b: ");
            b = Console.ReadLine();
            c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");//= Cộng chuỗi tức là a + b = ab

            //Cách 1: Ép kiểu string về số sử dụng Convert
            int kq1 = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine($"{a} + {b} = {kq1}");

            //Cách 2: Ép kiểu string về số sử dụng parse
            int kq2 = int.Parse(a) + int.Parse(b);
            Console.WriteLine($"{a} + {b} = {kq2}");
        }
    }
}
