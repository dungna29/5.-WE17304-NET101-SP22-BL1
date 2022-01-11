using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._9_ToanTuBaNgoi
{
    internal class Program
    {
        /*
      * TOÁN TỬ 3 NGÔI
      * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
      */
        static void Main(string[] args)
        {
            //Hỗ trợ hiển thị tiếng việt
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string temp1 = 9 > 8 ? "Đúng" : "Sai";
            int temp2 = 9 > 8 ? 1 : 0;
            bool temp3 = 9 > 8 ? true : false;
            double temp4 = 9 > 8 ? 1.0 : 0.5;
            Console.WriteLine(temp1);


            /*
            * Bài tập: Viết 1 chương trình khi nhập thông tin 1 người xác định được là ANH, CHỊ, EM, BẠN.
            * Cố định lại Tuổi và Giới Tính của bản thân
            */
            int namSinhBanThan = 2002, gioiTinh = 1;//Cố định 1 = Nam | 0 = Nữ
            //Yêu cầu nhập vào TÊN - NĂM SINH - GIỚI TÍNH có thể xác định được tên gọi như ở trên.
            //+1 điểm vào ASS1 ASS4 cho 4 bạn code nhanh và đúng nhất sử dụng toán tử 3 ngồi.
            do
            {
                string tenNguoi;
                int gtNguoi, nsNguoi;
                Console.WriteLine("Mời bạn nhập tên:");
                tenNguoi = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ns:");
                nsNguoi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập gt: (0 = Nữ | 1 = Nam)");
                gtNguoi = Convert.ToInt32(Console.ReadLine());
                var kq = (nsNguoi < namSinhBanThan && gtNguoi == 1) ? "Anh" :
                    (nsNguoi < namSinhBanThan && gtNguoi == 0) ? "Chị" :
                    (nsNguoi > namSinhBanThan) ? "Em" : "Bạn";
                Console.WriteLine($"Chào {kq} {tenNguoi}"); 
            } while (true);

        }
    }
}
