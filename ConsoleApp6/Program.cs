using System;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args){
            #region 1
            //    Console.Write("Enter the size of the matrix ");
            //    int n = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                Console.Write("1 ");
            //            else
            //                Console.Write("0 ");
            //        }
            //    }
            #endregion



            #region 2
            //Console.WriteLine("enter size of array:");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine(sum);
            #endregion



            #region 3
            //Console.Write("Enter the size ");
            //int size1 = int.Parse(Console.ReadLine());
            //int[] array1 = new int[size1];
            //int[] array2 = new int[size1];

            //Console.WriteLine("Enter elements of first array:");
            //for (int i = 0; i < size1; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements of second array:");
            //for (int i = 0; i < size1; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] array3 = array1.Concat(array2).ToArray();
            //Array.Sort(array3);
            //foreach (var item in array3)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 5
            Console.WriteLine("enter the size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < size; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min) min = array[i];
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            #endregion

            #region 6

            Console.WriteLine("enter the size of array:");
            int size2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(array);
            int seclarge = array[size - 2];
            Console.WriteLine(seclarge);
            #endregion

            ////msh arfaa 7 we 8
            #region 9
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string[] word = input.Split(' ');
            Array.Reverse(word);
            Console.WriteLine(string.Join(" ", word));
            #endregion

            #region 10

            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array3 = new int[rows, cols];
            int[,] array4 = new int[rows, cols];

            Console.WriteLine("Enter elements ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array3[i, j] = int.Parse(Console.ReadLine());
                    array4[i, j] = array3[i, j];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array4[i, j]);
                }
            }
            #endregion


            #region 11
            Console.WriteLine("enter size of array:");
            int size7 = int.Parse(Console.ReadLine());
            int[] array9 = new int[size];
            Console.WriteLine("enter elements");
            for (int i = 0; i < size7; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(array9);
            foreach (var item in array9)
            {
                Console.WriteLine(item);
            } 
            #endregion
        }
    }
}
