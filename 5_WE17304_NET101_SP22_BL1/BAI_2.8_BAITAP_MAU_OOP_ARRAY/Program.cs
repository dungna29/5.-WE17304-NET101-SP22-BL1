using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_BAITAP_MAU_OOP_ARRAY
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Menu Switch sẽ được triển khai ở đây và sẽ gọi Service ra để sử dụng
            string choice;
            CrushService cs = new CrushService();//Phải khởi tạo đối tượng thì mới dùng đc
            do
            {
                Console.WriteLine("Chương trình quản lý Crush");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Xuất danh sách");
                Console.WriteLine("5. Thêm 1 đối tượng (Ví dụ)");
                Console.WriteLine("6. Thoát");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        cs.bai1ThemMangDoiTuong();
                        break;
                    case "2":
                        cs.suaCrush();
                        break;
                    case "3":
                        cs.xoaCrush();
                        break;
                    case "4":
                        cs.bai4XuatDanhSach();
                        break;
                    case "5":
                        cs.bai5Them1DoiTuong();
                        break;
                    default:
                        break;
                }
            } while (choice!="6");
        }
    }
}
