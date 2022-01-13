using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1_Array
{
    internal class Program
    {/*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán;
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khai báo biến
            //<Kiểu dữ liệu> <Tên biến> = <Giá trị>;
            int a = 10;//Khai báo 1 biến a có kiểu dữ liệu là số nguyên và có khởi tạo giá trị ban đầu
            a = 5;

            //Phần 2: Khai báo 1 mảng phải đặt tên arr
            int[] arrNumber;//Khai báo 1 mảng số nguyên
            //Muốn dùng mảng bắt buộc phải khởi tạo
            arrNumber = new int[5];//Khởi tạo 1 mảng số nguyên có kích thước là 5 phần tử

            string[] arrString = new string[3];//Khởi tạo 1 mảng String gồm 3 phần tử
            double[] arrDoubles = { 8.6, 9.2, 5.6, 4.3 };//Khởi tạo 1 mảng có 4 phần tử bên trong.
            double[] arrDoubles1 = new double[] { 8.6, 9.2, 5.6, 4.3 };

            var arrDoubles2 = new double[5];//Khai báo ngầm định thì lúc này biến arrDoubles2 nó là 1 mảng số thực

            //Phần 3: Gán giá trị cho mảng cần quan tâm đến INDEX
            //arrNumber = 5; Sai vì không xác định được vị trí cần lưu vào
            arrNumber[0] = 5;//Gán giá trị vào index 0
            arrNumber[1] = 15;
            arrNumber[2] = 25;

            //Phần 4: Truy xuất giá trị trong mảng cần biết INDEX (Lưu vào đâu thì lấy ra ở đó)
            Console.WriteLine(arrNumber[0]);//=5
            Console.WriteLine(arrNumber[1]);
            Console.WriteLine(arrNumber[2]);
            Console.WriteLine(arrNumber[3]);
            Console.WriteLine(arrNumber[4]);
            //Console.WriteLine(arrNumber[5]);// IndexOutOfRangeException

            //Sử dụng for để in các phần tử trong mảng
            //arrNumber.Length = kích thước của mảng và là số nguyên
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine(arrNumber[i]);
            }

            //fore + tab = Vòng lặp foreach dùng để in tuần tự
            foreach (int x in arrNumber)
            {
                Console.WriteLine(x);
            }
            /*
        Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
        
        Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điểm thông báo Trượt hoặc đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
        */
            //Giải bài tập 1:
            int[] arrNumberB1;
            int size;
            Console.Write("Mời bạn nhập số lượng: ");
            size = Convert.ToInt32(Console.ReadLine());
            //Phải khởi tạo mảng theo kích thước người dùng nhập vào
            arrNumberB1 = new int[size];
            for (int i = 0; i < arrNumberB1.Length; i++)
            {
                Console.Write($"Mời bạn nhập index thứ {i}: ");
                arrNumberB1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Các số chẵn: ");
            // foreach (var x in arrNumberB1)
            // {
            //     if (x%2==0)
            //     {
            //         Console.Write(x + " ");
            //     }
            //
            //     // Console.WriteLine(x + (x >= 5 ? "Qua môn" : "Học lại")); Cách giải bài 2 nhanh
            // }

            int index = 0;
            for (int i = 0; i < arrNumberB1.Length * 2; i++)
            {
                if (i <= arrNumberB1.Length - 1)
                {
                    Console.Write(((arrNumberB1[i] % 2 == 0) ? Convert.ToString(arrNumberB1[i]) : "") + " ");
                }
                if (i == arrNumberB1.Length - 1)
                {
                    Console.WriteLine();
                }
                if (i > arrNumberB1.Length - 1)
                {
                   
                    Console.Write(((arrNumberB1[index] % 2 != 0) ? Convert.ToString(arrNumberB1[index]) : "") + " ");
                    index++;
                }
            }

            
        }
    }
}
