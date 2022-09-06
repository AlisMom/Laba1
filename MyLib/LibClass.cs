using System;

namespace MyLib
{
    public class LibClass
    {
        /// <summary>
        /// Метод вычисления количества отрицательных элементов в массиве
        /// </summary>
        /// <param name="arr">Исходный массив, в котором происходит вычисление</param>
        /// <returns>Возвращает количества отрицательных элементов в массиве</returns>
        public static int countNeg(Array arr)
        {
            int res = 0;
            foreach (double i in arr)
            {
                if (i < 0)
                {
                    res++;
                }
            }
            return res;
        }
        /// <summary>
        ///Метод вычисления суммы модулей элементов массива, расположенных после последнего минимального по модулю элемента.
        /// </summary>
        /// <param name="arr">Исходный массив, в котором происходит вычисление</param>
        /// <returns>Возвращает сумму</returns>
        public static double sumAbsAfterMinAbs(Array arr)
        {
            double min = Math.Abs(Convert.ToDouble(arr.GetValue(0)));
            double sum = 0;
            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                double nowElement = Math.Abs(Convert.ToDouble(arr.GetValue(i)));
                if (nowElement <= min)
                {
                    min = nowElement;
                    minIndex = i;
                }
            }

            for (int i = minIndex + 1; i < arr.Length; i++)
            {
                sum = sum + Math.Abs(Convert.ToDouble(arr.GetValue(i)));
            }
            return sum;
        }
        /// <summary>
        /// Метод замены всех отрицательных элементов массива их квадратами и упорядочивание элементов массива по возрастанию.
        /// </summary>
        /// <param name="arr">Исходный массив, в котором происходит вычисление</param>
        /// <returns>Возвращает массив</returns>
        public static Array sortSqrAndPos(Array arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                double nowElement = Convert.ToDouble(arr.GetValue(i));
                if (nowElement < 0)
                {
                    arr.SetValue(nowElement * nowElement, i);
                }
            }
            Array.Sort(arr);

            return arr;
        }
    }
}
