using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_Method_PhuongThuc
{
    class Method_Void_PhuongThucKhongTraVe
    {
        /*
        *  Phương thức không trả về là : Void

        *   Công thức chung:
            <Tên phương thức>: Viết thường ở từ đầu tiên và nó phải động từ
        *  <Phạm vi truy cập> <Kiểu phương thức> <Tên phương thức> (<Danh sách tham số>)
        *  {
        *          Body code
        *  }
        */
        //Phần 1: Phương thức trả về không tham số
        public void tinhTongCacSo()//() không tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tổng của a + b = {a+b}");
        }

        //Tên phương thức không thể trùng nhau
        // public void tinhTongCacSo()//() không tham số
        // {
        //     
        // }

        //Phần 2: Phương thức không trả về có tham số
        public void tinhTongCacSo(int a, int b)//(int a, int b) là 2 tham số
        {
            Console.WriteLine($"Tổng của a + b = {a + b}");
        }
        //Nạp chồng phương thức trong tính đa hình của lập trình OOP xem lại bài lý thuyết
        public void tinhTongCacSo(int a, int b,int c)
        {
            Console.WriteLine($"Tổng của a + b + c = {a + b + c}");
        }
        public void tinhTongCacSo(int a, int b, int c, int d)
        {
            Console.WriteLine($"Tổng của a + b + c + d = {a + b + c + d}");
        }
        public void tinhTongCacSo(int a, int b, int c, string d)
        {
           // Console.WriteLine($"Tổng của a + b + c + d = {a + b + c}");
           Console.WriteLine("Chịu không cộng đc");
        }
        //Tham số không nhất thiết phải có cùng kiểu dữ liệu
        public void method(double a, long b, int[] arr, Student st, List<Student> lstSV, Student[] arrSV)
        {
            foreach (var x in arrSV)
            {

            }

            for (int i = 0; i < arrSV.Length; i++)
            {

            }

        }
    }
}
