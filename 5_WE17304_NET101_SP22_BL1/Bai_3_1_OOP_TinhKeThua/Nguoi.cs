using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua
{
    //Người ta coi lớp này là lớp cha và về bản chất vẫn là 1 lớp đối tượng
    class Nguoi
    {
        //Đưa các thuộc tính chung lên trên lớp cha
        private string ten;
        private string ns;
        private string sdt;
        private string cccd;
        private string ngaySinh;
        private string email;
        private string diaChi;

        public Nguoi()
        {

        }

        public Nguoi(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi)
        {
            this.ten = ten;
            this.ns = ns;
            this.sdt = sdt;
            this.cccd = cccd;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.diaChi = diaChi;
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

        //Để cấp quyền kế thừa phương thức cho lớp con thì bổ sung từ khóa virtual
        public virtual void inRaManHinh1()
        {

        }
        private  void inRaManHinh2()
        {

        }
        public virtual void inRaManHinh3()
        {

        }
    }
}
