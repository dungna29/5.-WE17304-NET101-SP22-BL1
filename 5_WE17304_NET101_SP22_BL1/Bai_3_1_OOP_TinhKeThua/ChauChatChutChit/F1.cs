using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua.ChauChatChutChit
{
    class F1:F0
    {
        private string variable3;

        public F1()
        {
            
        }

        public F1(string variable1, string variable2, string variable3) : base(variable1, variable2)
        {
            this.variable3 = variable3;
        }

        public string Variable3
        {
            get => variable3;
            set => variable3 = value;
        }

        public override void method1(int a, string b)
        {
            base.method1(a, b);
        }

        public override void method2()
        {
            base.method2();
        }
    }
}
