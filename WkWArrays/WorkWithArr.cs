using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrSort;

namespace WkWArrays
{
    class WorkWithArray : SrAr
    {
        int x; int y;
       

        public override string ToString()
        {

            Console.WriteLine(base.ToString());
            return "new class";
         
        }
        public static int[,] ArrGen(int x, int y)
        {
            int[,] randt_arr = new int[y, x];
            Random rnd = new Random();

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    randt_arr[i, j] = rnd.Next(10, 199);
                }
            }

            return randt_arr;
        }

        public static void ArrOut(int arr_width, int arr_height, out int[,] procArr)
        {
            procArr = new int[arr_height, arr_width];
            procArr = WorkWithArray.ArrGen(arr_width, arr_height);

            for (int i = 0; i < arr_height; i++)
            {
                for (int j = 0; j < arr_width; j++)
                {
                    Console.Write(procArr[i, j] + " | ");
                }
                Console.WriteLine();
            }

        }
                
        public static void MaxVal(int[,] mass, int w, int h, out int max, out int xn, out int yn)
        {
            xn = 0;
            yn = 0;
            max = mass[0, 0];
            for (int i = 0; i < h; i++)
            {
                for (int j = 1; j < w; j++)
                {
                    if (mass[i, j] > max)
                    {
                        max = mass[i, j];
                        xn = j;
                        yn = i;
                    }
                }
            }
        }

        public static void MinVal(int[,] mass, int w, int h, out int min, out int xn, out int yn)
        {
            xn = 0;
            yn = 0;
            min = mass[0, 0];
            for (int i = 0; i < h; i++)
            {
                for (int j = 1; j < w; j++)
                {
                    if (mass[i, j] < min)
                    {
                        min = mass[i, j];
                        xn = j;
                        yn = i;
                    }
                }
            }
        }

        public static int Aver(int[,] mass, int w, int h)
        {
            int avr = 0;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    avr = avr + mass[i, j];
                }
            }

            return avr / mass.Length;
        }

        public static void Search(int[,] mass, int w, int h, int srnum, out int x, out int y)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (mass[i, j] == srnum)
                    {
                        x = j;
                        y = i;
                        return;
                    }
                }
            }
            x = -1;
            y = -1;                                              
        }

    }

   

}