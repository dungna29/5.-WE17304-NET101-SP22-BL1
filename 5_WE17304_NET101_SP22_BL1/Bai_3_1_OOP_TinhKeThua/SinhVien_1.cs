using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua
{
    class SinhVien_1
    {
        private string ten;
        private string ns;
        private string sdt;
        private string cccd;
        private string ngaySinh;
        private string email;
        private string diaChi;
        private string msv;
        private string nganhHoc;

        public SinhVien_1()
        {
            
        }

        public SinhVien_1(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string msv, string nganhHoc)
        {
            this.ten = ten;
            this.ns = ns;
            this.sdt = sdt;
            this.cccd = cccd;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.diaChi = diaChi;
            this.msv = msv;
            this.nganhHoc = nganhHoc;
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

        public void inRaManHinh()
        {

        }
    }
}
