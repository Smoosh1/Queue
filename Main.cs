using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var queue = new Queue<int>();

            queue.Enqueue(1);   
            queue.Enqueue(7);
            queue.Enqueue(42);
            queue.Enqueue(69);
            queue.Enqueue(-17);
            Console.WriteLine($"Тут {queue.Count} элементов.");

            /*А теперь нужно эту всю херабору в мейн запихнуть 
            var _Num = queue.Top();
            Console.WriteLine($"Первый элемент из очереди {_Num}.");*/

            Console.ReadLine();
        }
    }
}
