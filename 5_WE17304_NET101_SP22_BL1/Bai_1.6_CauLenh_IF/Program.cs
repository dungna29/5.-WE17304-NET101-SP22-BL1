using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._6_CauLenh_IF
{
    internal class Program
    {

        /*
        * Bài 1.5 Câu điều kiện rẽ nhánh IF
        * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó nếu thỏa mãn điều kiện.
        *
        * Công thức IF: if + tab       
        *   if (<Điều kiện>)
           {
               If phải luôn đúng
               Một hành động được thi khi thỏa mãn điều kiện
           }
        */
        static void Main(string[] args)
        {
            if (false)//Điều kiện để chạy câu lệnh trong if thì if phải luôn đúng
            {
                Console.WriteLine("Câu điều kiện 1");
            }
            
            if (true)
            {
                Console.WriteLine("Câu điều kiện 2");
            }
        }
    }
}
