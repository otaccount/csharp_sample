//using csharp_sample.basic;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace csharp_sample
{
    public class Test05
    {
        static void Test05Main(string[] args)
        {
            // 木の本数, 必要な平均個数
            int N, M;
            string[] line = Console.ReadLine().Split(' ');
            N = int.Parse(line[0]);
            M = int.Parse(line[1]);

            // 木に装飾されている電球の数
            int[] lights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // 電球の数を調べたい区間
            int Q = int.Parse(Console.ReadLine());

            // 始点と終点
            var list = new List<int[]>();
            for (int i = 0; i < Q; i++)
            {
                list.Add(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            }

            foreach (var i in list)
            {
                var start = i[0] - 1;
                var end = i[1] - 1;

                var avg = 0;
                for (var j = start; j < end + 1; j++)
                {
                    avg += lights[j];
                }
                avg = avg / (end + 1 - start);

                int n = 0;
                for (var j = start; j < end + 1; j++)
                {
                    if (avg < M)
                    {
                        if (M - avg > n)
                        {
                            n = M - avg;
                        }
                    }
                }

                for (var j = start; j < end + 1; j++)
                {
                    lights[j] += n;
                }
            }

            var first = true;
            foreach (var i in lights)
            {
                if (!first)
                {
                    Console.Write(" ");
                }
                Console.Write(i);
                first = false;
            }
            Console.WriteLine();
        }
    }
}