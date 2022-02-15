using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_BAITAP_MAU_OOP_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVienService_NangCao ss = new SinhVienService_NangCao();
            string input;
            while (true)
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Xuất ds");
                Console.WriteLine("Mời bạn chọn: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ss.themSV();//Cách gọi các chức năng và test bài
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
