using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_BAITAP_MAU_OOP_ARRAY
{
    //Đây là Class dùng để code thêm sửa xóa lấy danh sách đối tượng
    internal class CrushService
    {
        //Biến toàn cục bặc buộc gạch dưới và khai báo trên đầu class
        private Crush[] _arrCrushs;//Khai báo
        private string _input;
        private Crush _crush;

        //Luôn khởi tạo sẵn 1 contructor không tham số
        public CrushService()
        {

        }

        public void bai1ThemMangDoiTuong()
        {
            Console.WriteLine("Mời bạn nhập số lương: ");
            _input = Console.ReadLine();
            _arrCrushs = new Crush[Convert.ToInt32(_input)];//Muốn sử dụng mảng thì phải khởi tạo kèm kích thước mảng
            for (int i = 0; i < _arrCrushs.Length; i++)
            {
                _arrCrushs[i] = new Crush();//Bắt buộc phải khởi tạo đối tượng mới dùng đc
                Console.WriteLine("Mời bạn nhập tên: ");
                _arrCrushs[i].Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                _arrCrushs[i].Ns = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập sdt: ");
                _arrCrushs[i].Dt = Console.ReadLine();
                //Nhập giá trị cho thuộc tính cho 1 đối tượng
            }
        }
        public void suaCrush()
        {
            Console.WriteLine("Mời bạn nhập sdt: ");
            _input = Console.ReadLine();
            //Cách 1:
            for (int i = 0; i < _arrCrushs.Length; i++)
            {
                if (_arrCrushs[i].Dt == _input)
                {
                    Console.WriteLine("Mời bạn nhập tên: ");
                    _arrCrushs[i].Ten = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập năm sinh: ");
                    _arrCrushs[i].Ns = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mời bạn nhập sdt: ");
                    _arrCrushs[i].Dt = Console.ReadLine();
                }
            }
        }

        public void xoaCrush()
        {
            Console.WriteLine("Mời bạn nhập sdt: ");
            _input = Console.ReadLine();
            //Cách 1:
            for (int i = 0; i < _arrCrushs.Length; i++)
            {
                if (_arrCrushs[i].Dt == _input)
                {
                    _arrCrushs[i] = new Crush();
                }
            }
        }
        public void timCrush()
        {
            Console.WriteLine("Mời bạn nhập sdt: ");
            _input = Console.ReadLine();
            //Cách 1:
            // for (int i = 0; i < _arrCrushs.Length; i++)
            // {
            //     if (_arrCrushs[i].Dt == _input)
            //     {
            //         _arrCrushs[i].inRaManHinh();
            //     }
            // }
            //Cách 2: Linq để tìm
            _arrCrushs.ToList().Where(c=>c.Dt == _input).FirstOrDefault().inRaManHinh();
        }

        public void bai4XuatDanhSach()
        {
            foreach (var x in _arrCrushs)
            {
                x.inRaManHinh();
            }
        }

        public void bai5Them1DoiTuong()
        {
            _crush = new Crush();//Phải khởi tạo đối tượng thì mới dùng đc
            Console.WriteLine("Mời bạn nhập tên: ");
            _crush.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            _crush.Ns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập sdt: ");
            _crush.Dt = Console.ReadLine();
            //Nhập giá trị cho thuộc tính cho 1 đối tượng
            _crush.inRaManHinh();

        }
    }
}
