﻿using System;

/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов.
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D.
 * Формирование массива организовать при помощи метода.​
 *
 * Пример входных данных:
 * 5
 * 3
 * 4
 *
 * Пример выходных данных:
 * 3 7 11 15 19
 */

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask04();
        }

        public static void RunTask04()
        {
            int N = int.Parse(Console.ReadLine());

            int A, D;
            // TODO: считайте необходимые значения A и D
            
            // TODO: инициализируйте массив и передайте его в соответствующий метод вместе с необходимыми значениями 
            
            // TODO: выведите массив на экран
        }
        
        static void FillArray()
        {
            // TODO: заполните массив соответствующими данными
        }
    }
}