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
       
            var queue = new Queue<int>();

            queue.Enqueue(1);   
            queue.Enqueue(7);
            queue.Enqueue(42);
            queue.Enqueue(69);
            queue.Enqueue(-17);
            Console.WriteLine($"Тут {queue.Count} элементов.");

              
            var _Num = queue.Enqueue();
            Console.WriteLine($"Первый элемент из очереди {_Num}.";
            
            var After_Deleting_Num = queue.Pop();
            Console.WriteLine($"Теперь первый элемент очереди { After_Deleting_Num }.");
            
            var First_Num = queue.Top();
            Console.WriteLine($"Вставили элемент на позицию и верхний элемент теперь { First_Num }.");
            var pushing_Num = queue.Push();
            Console.WriteLine($"Вставили{ pushing_Num }.");

            Console.ReadLine();
    }
}
