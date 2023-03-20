//using csharp_sample.basic;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace csharp_sample
{
    public class Test03
    {
        static void Sample(string[] args)
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
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    var flg = false;
                    // 縦の列がtargetに含まれる場合
                    foreach (var t in target)
                    {
                        if (t[0] == i)
                        {
                            ans++;
                            flg = true;
                            break;
                        }
                    }

                    if (!flg)
                        // 横の列がtargetに含まれる場合
                        foreach (var t in target)
                        {
                            if (t[1] == j)
                            {
                                ans++;
                                break;
                            }
                        }
                }
            }

            Console.WriteLine(ans);
        }
    }
}