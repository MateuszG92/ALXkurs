using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L1
{
    public class L1Arrays
    {
        public static void Run()
        {
            int[] indexArray = { 1, 2, 3, 4, 5 };
            int[] intArray1 = new int[5];
            ShowArray(indexArray);

            intArray1[2] = 2;
            ShowArray(intArray1);

            int[] intArray2 = new int[3] {1,2,3};
            ShowArray(intArray2);

            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix2 = { { 2, 3 }, { 3, 4 } };
            Show2DArray(intMatrix);
            Show2DArray(intMatrix2);
        }

        public static void Run1()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";
            ShowArray(shoppingArray);
            shoppingArray[1] = "bread";
            ShowArray(shoppingArray);
            shoppingArray[5] = "meat";
            ShowArray(shoppingArray);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Numbet of items: {array.Length}");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void Show2DArray(int[,] matrix)
        {
            for (int iterator=0;iterator<matrix.GetLength(0);iterator++)
            {
                for (int iterator1 = 0; iterator1 < matrix.GetLength(1); iterator1++)
                {
                    Console.Write($"{matrix[iterator,iterator1]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
