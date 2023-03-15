using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_sample.basic
{
    public class Test01
    {
        public void Sample01()
        {
            // 整数の入力
            int a = int.Parse(Console.ReadLine());
            // スペース区切りの整数の入力
            string[] input = Console.ReadLine().Split(' ');
            int b = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            // 文字列の入力
            string s = Console.ReadLine();
            //出力
            Console.WriteLine((a + b + c) + " " + s);
        }

        public void Sample02()
        {
            string[] line = Console.ReadLine().Split(" ");
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            if (a * b % 2 == 0)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }
        }
    }
}
