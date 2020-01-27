using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    namespace Queue
    {

        public class Queue<Number>
        {
            #region Инициализация, ничего больше
            private List<Number> _number = new List<Number>();
            public int Count => _number.Count;
            #endregion
            #region вставляем элемент на позицию 

            public void ChoosePopNum(ref int _ChoosenNum)
            {
                Console.WriteLine("Выберите позицию элементика который надо вставить ");
                _ChoosenNum = int.Parse(Console.ReadLine());
            }

            public void Push(Number _Num, ref int _ChoosenNum)
            {
                if (_ChoosenNum > _number.Count)
                {
                    Console.WriteLine("Введи нормальное число");
                }
                else
                {
                    var Last_Num = _number[_number.Count - _ChoosenNum];
                }
                _number.Insert(_ChoosenNum,_Num);
            }

            #endregion
            #region смотрим на первый элемент 

            public Number Top()
            {
                var _Num = GetFirsNumber();
                return _Num;
            }
            #endregion
            #region удаляем первый элемент
            public void Pop(Number _Num)
            {
                 //_Num.RemoveAt(0);

            }
            #endregion
            #region Ищу первый элемент
            private Number GetFirsNumber()
            {
                var _FirsNum = _number.FirstOrDefault();

                if (_FirsNum == null)
                {
                    Console.WriteLine("Очередь пуста. Нет элементов для получения.");
                }
                return _FirsNum;
            }
            #endregion
        }
    }
}