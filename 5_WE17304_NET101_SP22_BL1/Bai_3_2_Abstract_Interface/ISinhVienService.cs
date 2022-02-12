using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    interface ISinhVienService
    {
        //Trong Interface không được phép private
        //Nếu phạm vi truy cập phương thức để mặc định thì cũng tự hiểu là public
        //Tên Interface luôn đi kèm với Service
        //Các phương thức ở interface là phương thức abstract
        void them();
        void sua();
        void xoa(int a);
    }
}
