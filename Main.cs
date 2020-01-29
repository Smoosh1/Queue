using System;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();

            queue.Push(1);
            queue.Push(7);
            queue.Push(42);
            queue.Push(69);
            queue.Push(-17);

                                                                    
            Console.WriteLine($"Тут {queue.Count} элементов.");


            var _Num = queue.GetFirsNumber();
            Console.WriteLine(_Num);

           
            int _Num_Pop = int.Parse(Console.ReadLine());
            queue.Pop(_Num_Pop);

            int _Num_Push = int.Parse(Console.ReadLine());
            queue.Push(_Num_Push);

            Console.ReadLine();
        }
    }
}
