using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCVC.Lib
{
    public static class ExtensionMethod
    {
        public static void FillChar<T>(this T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = value;
        }
        public static void FillChar<T>(this T[,] arr, T value)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = value;
                }
            }
        }

        public static char[] ReverseArray<T>(this T[,] arr, int Index)
        {
            int ArrayLength = arr.GetLength(1);
            char[] returnArr = new char[arr.GetLength(1)];

            for (int i = ArrayLength; i > 0; i--)
            {
                // Array Length : 16
                //  index : 0~15
                // AL 16 - i 16  0
                // al 16 - i 0 16
                returnArr[ArrayLength - i] = Convert.ToChar(arr[Index, i-1]);
            }
            return returnArr;
        }
    }
}
