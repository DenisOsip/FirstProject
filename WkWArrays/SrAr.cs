using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSort
{
    class SrAr
    {
        public int[] Sort (int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] < arr [j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public int[] Sort (int[] arr, bool flag)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public char[] Sort(char[] arr)
        {
            int[] temp_arr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp_arr[i] = (int)arr[i];
            }

            temp_arr = Sort(temp_arr);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)temp_arr[i];
            }

            return arr;
        }

        public virtual char[] Sort(char[] arr, bool flag)
        {
            int[] temp_arr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                temp_arr[i] = (int)arr[i];
            }

            temp_arr = Sort(temp_arr, false);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)temp_arr[i];
            }

            return arr;
        }

    }
}
