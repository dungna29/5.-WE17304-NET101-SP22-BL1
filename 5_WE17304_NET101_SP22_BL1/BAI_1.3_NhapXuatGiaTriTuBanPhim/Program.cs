using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._3_NhapXuatGiaTriTuBanPhim
{
    internal class Program
    {
        /*
        * BÀI 1.2 Nhập xuất ký tự từ bàn phím
        *  1. Xuất dữ liệu ra màn hình
        *      + Phím tắt : cw + tab
        *      + Console.WriteLine(); Ghi xong thì xuống dòng
        *      + Console.Write(); Ghi xong thì không xuống dòng
        *  2. Nhập giá trị từ bàn phím:
        *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
        *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
        */
        static void Main(string[] args)
        {
            //Hỗ trợ hiển thị tiếng việt
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            //1. Xuất dữ liệu ra màn hình cw + tab
            Console.Write("Chào các bạn đến với NGÀNH UDPM.NET");//Khi in ra thì không xuống dòng
            Console.WriteLine(" Vào năm 2022");
            Console.Write("ở FPOLY HN");
            Console.WriteLine(" Bạn {0} cố gắng qua môn Csharp 1 với điểm số = {1}","Hà",10.0);

            //2. Nhập giá trị từ bàn phím.
            //Ví dụ: Yêu cầu nhập vào tên và năm sinh sau đó in ra tuổi

            //Bước 1: Xác định số lượng biến sẽ sử dụng
            string name;
            int ns;
            //Bước 2: Hướng dẫn người sử dụng thực hiện hành động
            Console.WriteLine("Mời bạn nhập tên: ");
            name = Console.ReadLine();//Console.ReadLine() = string
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            ns = Convert.ToInt32(Console.ReadLine());
            //Bước 3: Thực thi
            Console.WriteLine($"Chào bạn: {name}, Năm sinh: {ns}, \n Tuổi: {2022-ns}");
        }
    }
}
