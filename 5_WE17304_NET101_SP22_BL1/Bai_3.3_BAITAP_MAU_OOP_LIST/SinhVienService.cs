using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_BAITAP_MAU_OOP_LIST
{
    class SinhVienService
    {
        private List<SinhVien> _lstSinhViens;
        private string _input;
        private SinhVien _sv;
        public SinhVienService()
        {
            //khởi tạo List khi lớp service được gọi
            _lstSinhViens = new List<SinhVien>();

        }

        public void fakeData()//Coi fakedata là 1 chức năng khi người dùng chọn thì sẽ tiến hành đổ data vào trong list
        {
            _lstSinhViens.AddRange(new List<SinhVien>
            {
                new SinhVien("Dũng","098123","00156845",2000,"PH123456","UDPM"),
                    new SinhVien("Hà","097123","00156845",2002,"PH4568","UDPM"),
                    new SinhVien("Tồn","097123","00156845",2005,"PH5687","UDPM")
            });
        }
        public void themSV()
        {

        }

        public void xuatDV()
        {

        }
        public void suaSV()
        {

        }
        public void xoaSV()
        {

        }
    }
}
