using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_Method_PhuongThuc
{
    class Method_TraVe
    {
        /*
          *  Phương thức trả về là :
          *   Công thức chung:
          *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
          *  {
          *          Body code
          *          return <Kiểu trả về của phương thức>
          *  }
          */
        /*
        * Hướng dẫn sử dụng:
        *      1. Phương thức phải có kiểu trả về là các kiểu dữ liệu...
        *      2. Phải Sử dụng return <giá trị hoặc tập giá trị> đúng với kiểu dữ liệu
        */
        //Phương thức trả về không tham số
        public int tinhTongCacSo()//() không tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số b: ");
            b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }
        //Ví dụ: Tạo ra 1 mảng năm từ 1800 đến 2022
        public int[] getYears1800_2022()
        {
            int[] arr = new int[2023 - 1800];
            int temp = 1800;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp;
                temp++;
            }
            return arr;
        }

        public Student getStudent()//Cả phương thức trả về 1 đối tượng sinh viên
        {
            Student st = new Student();
            return st;
        }
        public List<Student> getStudent1()//Cả phương thức trả về 1 danh sách sinh viên
        {
            List<Student> st = new List<Student>();
            return st;
        }
    }
}
