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
            Console.WriteLine("Mòi bạn nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _sv = new SinhVien();//Bắt buộc phải khởi tạo thi mới dùng được
                Console.WriteLine("Mời bạn nhập tên: ");
                _sv.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập sđt: ");
                _sv.Sdt = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập cccd: ");
                _sv.Ccd = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ns: ");
                _sv.Ns = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập msv: ");
                _sv.Msv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ngành: ");
                _sv.Nganh = Console.ReadLine();
                //Sau khi lấy được đầy đủ dữ liệu gán cho đối tượng thì phải add vài List
                _lstSinhViens.Add(_sv);
            }
            Console.WriteLine("Thêm thành công");
        }

        public void xuatDV()
        {
            foreach (var x in _lstSinhViens)
            {
                x.inRaManHinh();
            }
            //Collections
        }
        public void sapXepNguoc()
        {
            _lstSinhViens.OrderBy(c => c.Msv);//Câu lệnh không có tác dụng
            //Đề bài mà muốn khi bấm vào thì sẽ sắp xếp cái danh sách thật thì lú cày bọn em phải clear danh sách thật và gán lại cho nó vào danh sách đã sắp xếp
            var temp = _lstSinhViens.OrderBy(c => c.Msv);//temp nó sẽ hứng cái List đã bị sắp sắp xếp xuôi
            _lstSinhViens = new List<SinhVien>();
            _lstSinhViens = temp.ToList();
            // foreach (var x in _lstSinhViens.OrderByDescending(c=>c.Msv))
            // {
            //     x.inRaManHinh();
            // }
            //Collections
        }
        public void suaSV()
        {
            Console.WriteLine("Mời bạn nhập mã: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Msv == _input)
                {
                    
                    Console.WriteLine("Mời bạn nhập tên: ");
                    _lstSinhViens[i].Ten = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập sđt: ");
                    _lstSinhViens[i].Sdt = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập cccd: ");
                    _lstSinhViens[i].Ccd = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập ns: ");
                    _lstSinhViens[i].Msv = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập ngành: ");
                    _lstSinhViens[i].Nganh = Console.ReadLine();
                    Console.WriteLine("Sửa thành công");
                    break;
                }
            }
        }
        public void xoaSV()
        {
            Console.WriteLine("Mời bạn nhập mã: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Msv == _input)
                {
                    _lstSinhViens.RemoveAt(i);
                    Console.WriteLine("Xóa thành công");
                    return;
                }
            }
        }
        public void timKiemSVTheoMsv()
        {
            Console.WriteLine("Mời bạn nhập mã: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Msv == _input)
                {
                    _lstSinhViens[i].inRaManHinh();
                    break;
                }
            }

        }
    }
}
