using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._8_CauLenh_Else_If
{
    internal class Program
    {

        /*
       * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
       *
       * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
       *
       * Công thức:
       *   if (true)
          {
              //Thực hiện 1 hành động nếu If đúng
          }else if (<Điều kiện 1>)
          {
              //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
          }else if (<Điều kiện 2>)
          {
              //Tương tự
          }else
          {
              //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
          }
       */
        static void Main(string[] args)
        {
            double diemGPACsharp;
            Console.WriteLine("Mời bạn nhập điểm: ");
            diemGPACsharp = Convert.ToDouble(Console.ReadLine());
            if (diemGPACsharp>= 9 && diemGPACsharp <=10)
            {
                Console.WriteLine("Tặng 1 chiếc IPHONE 13 PRO MAX");
            }else if (diemGPACsharp >= 8 && diemGPACsharp < 9)
            {
                Console.WriteLine("Tặng 1 chiếc IPHONE 12 PRO");
            }else if (diemGPACsharp >= 6 && diemGPACsharp < 8)
            {
                Console.WriteLine("Tặng 1 chiếc IPHONE 8");
            }else if (diemGPACsharp >= 5 && diemGPACsharp < 6)
            {
                Console.WriteLine("Không tặng gì");
            }
            else
            {
                Console.WriteLine("Khuyến mãi 1 hộp đánh giày");
            }
        }
    }
}
