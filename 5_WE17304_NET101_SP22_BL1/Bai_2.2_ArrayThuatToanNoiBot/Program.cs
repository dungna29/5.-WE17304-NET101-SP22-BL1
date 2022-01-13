using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._2_ArrayThuatToanNoiBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Viết ra giấy trên từng lần chạy hoặc word hoặc excel
            //2. 1 Cách thông minh hơn
            int[] arrNumbers = { 9, 8, 7, 6, 5 };
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
            /*
             * 9, 8, 7, 6, 5
             * Vòng 1 - i = 0; 
             * index[i] = 9 > index[j]1 = 8
             * 8, 9, 7, 6, 5
             * index[i] = 8 > index[j]2 = 7
             * 7, 9, 8, 6, 5
             * index[i] = 7 > index[j]3 = 6
             * 6, 9, 8, 7, 5
             * index[i] = 6 > index[j]4 = 5
             * 5, 9, 8, 7, 6
             * Vòng 2 - i = 1;
             * index[i] = 9 > index[j]2 = 8
             * 5, 8, 9, 7, 6
             * index[i] = 8 > index[j]3 = 7
             * 5, 7, 9, 8, 6
             * index[i] = 7 > index[j]4 = 6
             * 5, 6, 9, 8, 7
             * Vòng 3 - i = 2;
             * index[i] = 9 > index[j]3 = 8
             * 5, 6, 8, 9, 7
             * index[i] = 8 > index[j]4 = 7
             * 5, 6, 7, 9, 8
             * Vòng 4 - i = 3;
             * index[i] = 9 > index[j]4 =8
             * 5, 6, 7, 8, 9
             */
            // for (int i = 0; i < arrNumbers.Length - 1; i++)
            // {
            //     for (int j = i + 1; j < arrNumbers.Length; j++)
            //     {
            //         if (arrNumbers[i] > arrNumbers[j])
            //         {
            //             int temp = arrNumbers[i];
            //             arrNumbers[i] = arrNumbers[j];
            //             arrNumbers[j] = temp;
            //         }
            //     }
            // }

            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                Console.WriteLine("Lần chay thứ: " + i);
                foreach (var x in arrNumbers)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("");
                for (int j = i + 1; j < arrNumbers.Length; j++)
                {
                    Console.Write("Điều kiện {0} > {1} \n", arrNumbers[i], arrNumbers[j]);
                    if (arrNumbers[i] > arrNumbers[j])
                    {
                        int temp = arrNumbers[i];
                        arrNumbers[i] = arrNumbers[j];
                        arrNumbers[j] = temp;
                        Console.Write("Hoán vị của:{0} & {1} \n", arrNumbers[i], arrNumbers[j]);
                        foreach (int x in arrNumbers)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine();
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}
