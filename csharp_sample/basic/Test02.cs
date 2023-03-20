using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_sample.basic
{
    internal class Test02
    {
        public void Test01()
        {
            String[] line = Console.ReadLine().Split(' ');
            int H = int.Parse(line[0]);
            int W = int.Parse(line[1]);


            List<int[]> list = new List<int[]>();
            for (int i = 0; i < H * 2; i++)
            {
                String[] readLine = Console.ReadLine().Split(' ');

                int[] tmp = new int[readLine.Length];
                for (int k = 0; k < readLine.Length; k++)
                {
                    tmp[k] = int.Parse(readLine[k]);
                }
                list.Add(tmp);
            }

            List<int[]> ansList = new List<int[]>();

            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < H * 2; i++)
            {
                int[] ansData1 = list[counter];
                int[] ansData2 = null;
                if (i > 0)
                {
                    ansData2 = list[H + counter2];
                }

                int colno = 0;
                int colno2 = 0;
                List<int> avgList = new List<int>();
                for (int k = 0; k < ansData1.Length * 2; k++)
                {
                    if (k > 0 && ansData2 != null)
                    {
                        avgList.Add((ansData1[colno] + ansData2[colno2]) / 2);
                    }
                    else
                    {
                        avgList.Add(ansData1[colno]);
                    }

                    if (k % 2 == 1)
                    {
                        colno++;
                    }
                    if (k > 0 && k % 2 == 0)
                    {
                        colno2++;
                    }
                }

                ansList.Add(avgList.ToArray());

                if (i % 2 == 1)
                {
                    counter++;
                }
                if (i > 0 && i % 2 == 0)
                {
                    counter2++;
                }
            }

            int r = 0;
            foreach (int[] i in ansList)
            {
                int c = 0;
                if (r > 0)
                {

                    foreach (int k in i)
                    {
                        if (c > 0)
                        {
                            if (c != 1)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(k);
                        }
                        c++;
                    }
                    Console.WriteLine("");
                }
                r++;
            }
        }
    }
}
