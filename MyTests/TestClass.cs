using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static MyLib.LibClass;

namespace MyTests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        // Тест метода вычисления количества отрицательных элементов в массиве
        public void testCountNeg()
        {
            // Исходные данные для теста.
            Array arr = new double[] { -4, 5, -3, 0};
            // Ожидаемые значения 
            int expected = 2;
            // Вызов тестируемой функции.
            int result = countNeg(arr);
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void testCountNeg1()
        {
            // Исходные данные для теста.
            Array arr = new double[] { -12, -93, -31, -43 };
            // Ожидаемые значения 
            int expected = 4;
            // Вызов тестируемой функции.
            int result = countNeg(arr);
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void testCountNeg2()
        {
            // Исходные данные для теста.
            Array arr = new double[] { 53, 15, 766, 21 };
            // Ожидаемые значения 
            int expected = 0;
            // Вызов тестируемой функции.
            int result = countNeg(arr);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        // Тест метода вычисления суммы модулей элементов массива,
        // расположенных после последнего минимального по модулю элемента.
        public void testSumAbsAfterMinAbs()
        {
            // Исходные данные для теста.
            Array arr = new double[] { 5, 0, -3, -4 };
            // Ожидаемые значения 
            double expected = 7;
            // Вызов тестируемой функции.
            double result = sumAbsAfterMinAbs(arr);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testSumAbsAfterMinAbs1()
        {
            // Исходные данные для теста.
            Array arr = new double[] { 2, 1, 6, 8 };
            // Ожидаемые значения 
            double expected = 14;
            // Вызов тестируемой функции.
            double result = sumAbsAfterMinAbs(arr);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testSumAbsAfterMinAbs2()
        {
            // Исходные данные для теста.
            Array arr = new double[] { -11, -2, -4 -12 };
            // Ожидаемые значения 
            double expected = 16;
            // Вызов тестируемой функции.
            double result = sumAbsAfterMinAbs(arr);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        // Тест метода замены всех отрицательных элементов массива
        // их квадратами и упорядочивание элементов массива по возрастанию.
        public void testSortSqrAndPos()
        {
            // Исходные данные для теста.
            Array arr = new double[] { -4, 5, -3, 0 };
            // Ожидаемые значения 
            Array expected = new double[] { 0, 5, 9, 16 };
            // Вызов тестируемой функции.
            Array result = sortSqrAndPos(arr);
            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testSortSqrAndPos1()
        {
            // Исходные данные для теста.
            Array arr = new double[] { -6, -2, -5, -3 };
            // Ожидаемые значения 
            Array expected = new double[] {4 , 9, 25, 36 };
            // Вызов тестируемой функции.
            Array result = sortSqrAndPos(arr);
            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testSortSqrAndPos2()
        {
            // Исходные данные для теста.
            Array arr = new double[] { 7, 2, 8, 1 };
            // Ожидаемые значения 
            Array expected = new double[] { 1, 2, 7, 8 };
            // Вызов тестируемой функции.
            Array result = sortSqrAndPos(arr);
            CollectionAssert.AreEqual(result, expected);
        }
    }
}
