using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp57
{
    class Queue<Number>
    {

        private List<Number> _number = new List<Number>();
        public int Count => _number.Count;

        private int first = -1;


        public void Push(Number _Num)
        {             
            _number.Add(_Num);
            if (first == -1)
                first = 0;

        }

  

        public Number Top()
        {
            var _Num = GetFirsNumber();
            return _Num;
        }

        public void Pop(Number _Num)
        {
            _number.RemoveAt(first);
        }

        public Number GetFirsNumber()
        {
            var _FirsNum = _number.FirstOrDefault();

            if (_FirsNum == null)
            {
                Console.WriteLine("Очередь пуста. Нет элементов для получения.");
            }
            return _FirsNum;
        }
    }
}
