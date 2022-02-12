using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_1_OOP_TinhKeThua
{
    //SinhVien thì được gọi là lớp con
    class SinhVien:Nguoi//Sử dụng dấu : để kế thừa
    {
        //Lớp con chỉ cần khai báo các thuộc tính riêng
        private string msv;
        private string nganhHoc;

        public SinhVien()
        {
            
        }
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public SinhVien(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string msv1, string nganhHoc) : base(ten, ns, sdt, cccd, ngaySinh, email, diaChi)
        {
            msv = msv1;
            this.nganhHoc = nganhHoc;

            //this dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //base dùng để tham chiếu đến thuộc tính và phương thức của lớp cha
           
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string NganhHoc
        {
            get => nganhHoc;
            set => nganhHoc = value;
        }

        public void method1()
        {
            Console.WriteLine(Ten);
        }
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.

        //override ghi đè phương thức
        public override void inRaManHinh1()
        {
            //base.inRaManHinh1();
            //Khi đã kế thừa lại phương thức của cha có quyền code lại phương thức bên trong
            Console.WriteLine("Đây là phương thức của lớp con kế thừa đã viết lại");
        }

        public override void inRaManHinh3()
        {
            base.inRaManHinh3();
        }
    }
}
