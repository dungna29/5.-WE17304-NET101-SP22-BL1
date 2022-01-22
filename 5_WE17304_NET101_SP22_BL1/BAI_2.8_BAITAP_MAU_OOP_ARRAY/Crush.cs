using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_BAITAP_MAU_OOP_ARRAY
{
    internal class Crush
    {
        private string ten;
        private int ns;
        private string dt;

        public Crush()
        {
            
        }

        public Crush(string ten, int ns, string dt)
        {
            this.ten = ten;
            this.ns = ns;
            this.dt = dt;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public string Dt
        {
            get => dt;
            set => dt = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine($"{Ten} | {Dt} | {Ns} | {2022-Ns}");
        }
    }
}
