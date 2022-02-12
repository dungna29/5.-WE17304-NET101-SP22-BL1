using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    //abstract Vễ bản chất vẫn là một lớp cha hoàn toàn bình thường.
    //Đã 1 lớp abstract thì phải có phương thức abstract
    abstract class Nguoi
    {
        
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

        public virtual void inRaManHinh1()
        {
            Console.WriteLine("Đây là phương thức inRaManHinh1()");
        }
        private void inRaManHinh2()
        {

        }
        public virtual void inRaManHinh3()
        {

        }
        /*
         * 1. Phương thức abstract không có body code
         */
        public abstract void inRaManHinh4();
        public abstract void inRaManHinh5(int a, int b);
    }
}
