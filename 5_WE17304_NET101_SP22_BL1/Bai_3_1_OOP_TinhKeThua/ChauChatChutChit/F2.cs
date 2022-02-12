using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua.ChauChatChutChit
{
    class F2:F1
    {
        private string variable4;

        public F2()
        {
            
        }

        public F2(string variable1, string variable2, string variable3, string variable4) : base(variable1, variable2, variable3)
        {
            this.variable4 = variable4;
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
