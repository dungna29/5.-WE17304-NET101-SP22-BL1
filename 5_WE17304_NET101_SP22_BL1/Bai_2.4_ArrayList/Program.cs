using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4_ArrayList
{
    internal class Program
    {
        /*
         *  ArrayList
         *  Định nghĩa: Là một Collection giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections

            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          */
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khai báo mảng
            //Khai báo mảng phải luôn khởi tạo kích thước mảng
            int[] arrNumbers = new int[5];

            //Phần 2: Khai báo và khởi tạo ArrayList
            ArrayList arrLstNumber1;//Khai báo
            arrLstNumber1 = new ArrayList();//Khởi tạo thì mới sử dụng được

            //Phần 3: Gán giá trị sử dụng phương thức add()
            arrLstNumber1.Add(1);
            arrLstNumber1.Add("1");
            arrLstNumber1.Add('a');
            arrLstNumber1.Add(true);
            arrLstNumber1.Add(8.5);

            //Phần 4: Truy xuất giá trị
            Console.WriteLine(arrLstNumber1[0]);//Lấy ra giá trị ở index 0
            //arrLstNumber1.Count = độ dài của Arraylist
            for (int i = 0; i < arrLstNumber1.Count; i++)
            {
                Console.Write(arrLstNumber1[i] + " ");
            }
            Console.WriteLine();

            //Phần 5: Có rất phương thức cần phải học với 1 kiểu dữ liệu dạng Collections
            arrLstNumber1.RemoveAt(0);//Xóa 1 phần tử ở vị trí thứ 0
            
            //Còn có rất nhiều phương thức khác cần search trước khi sử dụng hoặc đọc tiếng anh.
        }
    }
}
