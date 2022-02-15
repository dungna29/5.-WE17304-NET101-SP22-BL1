using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_BAITAP_MAU_OOP_LIST
{
    class SinhVien:Nguoi
    {

        private string msv;
        private string nganh;

        public SinhVien()
        {
            
        }

        public SinhVien(string ten, string sdt, string ccd, int ns, string msv, string nganh) : base(ten, sdt, ccd, ns)
        {
            this.msv = msv;
            this.nganh = nganh;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Nganh
        {
            get => nganh;
            set => nganh = value;
        }

        public override void inRaManHinh()
        {
            Console.WriteLine($"{Ten} {Ns} {2022-Ns} {Sdt} {Ccd} {msv} {Nganh} ");
        }
    }
}
