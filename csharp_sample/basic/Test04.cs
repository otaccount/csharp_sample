//using csharp_sample.basic;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace csharp_sample
{
    public class Test04
    {
        static void Test04Main(string[] args)
        {
            int H, W;
            string[] input = Console.ReadLine().Split(' ');
            H = int.Parse(input[0]);
            W = int.Parse(input[1]);

            List<string> inputList = new List<string>();
            for (int i = 0; i < H; i++)
            {
                inputList.Add(Console.ReadLine());
            }


            var target = new List<int[]>();
            int cnt_str = 0;
            foreach (string str in inputList)
            {
                int cnt_c = 0;
                foreach (char c in str)
                {
                    if (c == '#')
                    {
                        target.Add(new int[] { cnt_str, cnt_c });
                    }
                    cnt_c++;
                }
                cnt_str++;
            }

            int ans = 0;

            var colHt = new HashSet<int>();
            var rowHt = new HashSet<int>();
            foreach (var i in target)
            {
                colHt.Add(i[0]);
                rowHt.Add(i[1]);
            }

            ans = colHt.Count * W + rowHt.Count * H - colHt.Count * rowHt.Count;
            Console.WriteLine(ans);
        }
    }
}