using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua.ChauChatChutChit
{
    class F0//Coi thế hệ đầu tiên
    {
        private string variable1;
        private string variable2;

        public F0()
        {
            
        }

        public F0(string variable1, string variable2)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
        }

        public string Variable1
        {
            get => variable1;
            set => variable1 = value;
        }

        public string Variable2
        {
            get => variable2;
            set => variable2 = value;
        }

        public virtual void method1(int a, string b)
        {

        }
        public virtual void method2()
        {

        }
    }
}
