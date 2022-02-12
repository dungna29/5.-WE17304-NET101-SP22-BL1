using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua
{
    class Program
    {
        static void Main(string[] args)
        { /*
             * 1.Khi kế thừa thì lớp con sẽ có đầy đủ các thuộc tính và phương thức của lớp cha
           *   2.Khi sử dụng contructor lớp con sẽ vẫn đầy đủ các tham số để gán thuộc tính cho đối tượng
             */
            SinhVien sv = new SinhVien();
            //Đối với không tham số thì sẽ chấm các property để gán giá trị cho thuộc tính
            sv.Ten = "Dũng";
            sv.NganhHoc = "UDPM";
            sv.Cccd = "0123456";
            //.......
            SinhVien sv2 = new SinhVien("Dũng", "1988", "0123", "0123", "30/12", "@gmail", "Số 1 ngõ 43", "PH1234",
                "UDPM");

            //Ghi đè phương thức:
            Nguoi n = new Nguoi();
            n.inRaManHinh1();
            SinhVien sv3 = new SinhVien();
            sv3.inRaManHinh1();
        }

        int a;
        void method1()
        {

        }
    }
}
