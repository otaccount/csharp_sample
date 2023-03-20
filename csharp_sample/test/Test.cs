using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_sample.test
{
    internal class Test
    {
        static void Main2()
        {
            var hash = new HashSet<int>();
            hash.Add(1);
            hash.Add(2);
            hash.Add(1);

            foreach(var i in hash)
            {
                Console.WriteLine(i);
            }
        }

        void Test1()
        {
            Console.WriteLine("hello");

            var test = "test";
            foreach (char i in test)
            {
                Console.WriteLine(i);
            }
        }
    }
}
