using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ISinhVienService iSinhVienService = new SinhVienService();
            iSinhVienService.them();
            iSinhVienService.sua();
        }
    }
}
