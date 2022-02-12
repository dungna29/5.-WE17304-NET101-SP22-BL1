using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_2_Abstract_Interface
{
    //1 Lớp có thể Implement nhiều Interface
    class SinhVienService:ISinhVienService
    {
        //Code các chức năng CRUD của đối tượng
        //Khi Implement interface sẽ bắt buộc ghi đè lại tất cả các phương thức của Interface
        public void them()
        {
            throw new NotImplementedException();
        }

        public void sua()
        {
            throw new NotImplementedException();
        }

        public void xoa(int a)
        {
            throw new NotImplementedException();
        }
    } 
}
