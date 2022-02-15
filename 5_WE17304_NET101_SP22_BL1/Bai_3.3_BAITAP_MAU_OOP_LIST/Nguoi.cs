using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_BAITAP_MAU_OOP_LIST
{
    class Nguoi//Lớp cha
    {

        private string ten;
        private string sdt;
        private string ccd;
        private int ns;

        public Nguoi()
        {

        }

        public Nguoi(string ten, string sdt, string ccd, int ns)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.ccd = ccd;
            this.ns = ns;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Ccd
        {
            get => ccd;
            set => ccd = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public virtual void inRaManHinh()
        {

        }
    }
}
