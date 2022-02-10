using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua
{
    //Tạo tiếp lớp cuối cùng lớp bảo vệ _1 và lớp này có 2 thuộc tính mã nhân viên và ca trực và riêng biệt còn các thuộc tính giống nhau.
    class GiangVien_1
    {
        private string ten;
        private string ns;
        private string sdt;
        private string cccd;
        private string ngaySinh;
        private string email;
        private string diaChi;

        private string mgv;
        private string gioDay;

        public GiangVien_1()
        {
            
        }

        public GiangVien_1(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string mgv, string gioDay)
        {
            this.ten = ten;
            this.ns = ns;
            this.sdt = sdt;
            this.cccd = cccd;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.diaChi = diaChi;
            this.mgv = mgv;
            this.gioDay = gioDay;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ns
        {
            get => ns;
            set => ns = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Cccd
        {
            get => cccd;
            set => cccd = value;
        }

        public string NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public string Mgv
        {
            get => mgv;
            set => mgv = value;
        }

        public string GioDay
        {
            get => gioDay;
            set => gioDay = value;
        }

        public void inRaManHinh()
        {

        }
    }
}
