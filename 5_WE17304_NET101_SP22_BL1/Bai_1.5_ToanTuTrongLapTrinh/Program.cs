using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._5_ToanTuTrongLapTrinh
{
    internal class Program
    {/*
         * 4 Loại toán tử trong lập trình
         *  1. Toán tử số học:
         *  (+ - * / % ++ --)
         *      +: Tính tổng của 2 số hoặc dùng để cộng chuỗi
         *      -: Phép trừ của 2 số
         *      *: Phép nhân của 2 số
         *      %: Phép chia lấy dư của 2 số
         *      ++: Tăng lên 1 đơn vị
         *      --: Giảm 1 đơn vị
         *  2. Toán tử so sánh:
         *  (> < >= <= == !=)
         *      >: Lớn hơn
         *      <: nhỏ hơn
         *      >=: lớn hơn hoặc bằng
         *      <=: nhỏ hơn hoặc bằng
         *      ==: so sánh bằng
         *      !=: so sánh khác
         *  3. Toán tử Logic:
         * (&& || !)
         *      &&: Yêu cầu các mệnh đề phải luôn đúng
         *      ||: Yêu cầu 1 trong các mệnh đề dúng là được
         *      !: Lấy giá trị phủ định của mệnh đề.
         *  4. Toán tử gán:
         * (= += -= *= /= %=)
         *      +=: Cộng tiếp với vế bên phải các phép còn lại tương tự
         */
        static void Main(string[] args)
        {
            //1. Toán tử số học:
            int a = 4;
            a++;//a = 5
            a--;//a = 4
            ++a;//a = 5
            //Postfix và Prefix ++ -- sẽ là thay đổi kết quả bài toán.
            int d = 10,c = 9,kq;
            kq = d++ + ++c - 2;

            //2. Toán tử so sánh:
            Console.WriteLine("5 > 5 = {0}",5>5);//=false
            Console.WriteLine("5 == 5 = {0}",5==5);//=true
            //....Sử dụng rất nhiều với các câu điều kiện

            //3. Toán tử logic
            int soBuoiNghi = 4;
            double diemTP = 5, diemThi = 4.9;
            Console.WriteLine(soBuoiNghi<=4 && diemTP >=5 && diemThi >=5);//=false
            Console.WriteLine(soBuoiNghi<=4 || diemTP >=5 || diemThi >=5);//=false
            //4. Toán tử gán
            int temp = 100;
            temp += 10;// temp = 110 -> Tường minh hơn temp = 100 + 10 = 110;

        }
    }
}
