using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    /*
     * Khi lớp con kế thừa 1 lớp cha là abstract thì bắt buộc phải ghi đè hết tất cả các phương thức abstract
     */
    class SinhVien : Nguoi
    {

        private string msv;
        private string nganhHoc;

        public SinhVien()
        {

        }

        public SinhVien(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string msv1, string nganhHoc) : base(ten, ns, sdt, cccd, ngaySinh, email, diaChi)
        {
            msv = msv1;
            this.nganhHoc = nganhHoc;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }

        public void method1()
        {
            Console.WriteLine(Ten);
        }

        public override void inRaManHinh1()
        {
            Console.WriteLine("Đây là phương thức của lớp con kế thừa đã viết lại");
        }

        public override void inRaManHinh3()
        {
            base.inRaManHinh3();
        }
        /*
         * Bắt buộc ghi đè phương thức abstract và triển khai code như bình thường.
         */
        public override void inRaManHinh4()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh5(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
