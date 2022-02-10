using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bai_2._9_Method_PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Phần 1: Phương thức không trả về void
            Method_Void_PhuongThucKhongTraVe khongTraVe = new Method_Void_PhuongThucKhongTraVe();
            /*
          * 1. Hướng dẫn sử dụng phương thức không trả về không tham số:
          *      - Cần biết tên phương thức và phương thức đó đang nằm trong class nào.
          *      - Khi gọi ra kết thúc phải ();
          */
            //khongTraVe.tinhTongCacSo; Lỗi khi sử dụng thiếu ();
            //khongTraVe.tinhTongCacSo();

        /*
         * 2. Sử dụng phương thức không trả có tham số:
         *      - Bắt buộc truyền đúng thứ tự vị trí tham số và đúng kiểu dữ liệu
         *      - Bắt buộc phải truyền tham số nếu phương thức có
         *      - Nếu là nạp chồng phương thức thì truyền số lượng tham số sẽ gọi phương thức cần gọi
         */
            // khongTraVe.tinhTongCacSo(2,2);
            // khongTraVe.tinhTongCacSo(2,2,2);
            // khongTraVe.tinhTongCacSo(2,2,2,5);
            // khongTraVe.tinhTongCacSo(2,2,2,"1");
            //khongTraVe.tinhTongCacSo(2,2,2,5,6); Truyền thừa tham số vì bên kia không có phương thức nào có tận 5 tham số
            #endregion

            #region Phần 2: Phương trả về
            //Cách sự dụng giống void
            Method_TraVe mt = new Method_TraVe();
            mt.tinhTongCacSo();//Phương thức trả về là 1 giá trị hoặc tập giá trị không thể tự in ra
            //int kq = mt.tinhTongCacSo() + "2000"; Sai vì không cùng kiểu dữ liệu
            int kq1 = mt.tinhTongCacSo() + 2000;
            Console.WriteLine(mt.tinhTongCacSo()+2000);//Khi in giá trị chúng ta có thể thao với nó tương ứng với kiểu dữ liệu của phương thức

            Console.WriteLine(mt.getYears1800_2022().Length);//Xem độ dài của mảng
            foreach (var x in mt.getYears1800_2022())//In tất cả các phần tử trong mảng
            {
                Console.WriteLine(x);
            }

            #endregion
        }
    }
}
