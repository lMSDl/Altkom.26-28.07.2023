using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string> { "1", "2", "3", "4" };

            var bufferedElement = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(bufferedElement + list[i]);
                bufferedElement = list[i];
            }


            using var enumerator = list.GetEnumerator();
            while( enumerator.MoveNext() )
            {
                Console.WriteLine(enumerator.Current);
            }
            //enumerator.Dispose();

            var buffer = new Buffer<string>(list);
            using var bufferEnumerator = buffer.GetEnumerator();
            while(bufferEnumerator.MoveNext())
            {
                Console.WriteLine(bufferEnumerator.Current.Item1 + bufferEnumerator.Current.Item2);
            }

            foreach(var element in buffer)
            {
                Console.WriteLine(element.Item1 + element.Item2);
            }
        }
    }
}
