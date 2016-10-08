using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArrSort;

namespace WkWArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i_arr_width = 5, i_arr_height = 5, i_maxval = 0, i_minval = 0, i_maxwidth = 0, i_maxheght = 0;
            int i_minwidth = 0, i_minheight = 0, vvod = -1, i_srx = -1, i_sry = -1, i_srnum = 0;
            int[,] save_arr = new int[i_arr_width, i_arr_height];


            WorkWithArray.ArrOut(i_arr_width, i_arr_height, out save_arr);

        rel:
            Console.WriteLine("\n1. Регенерация массива\n2. Максимальное значение в массиве\n3. Минимальное значение в массиве\n4. Среднее значение элементов массива\n5. Поиск первого совпадающего с введённым значения\n0. Выход\n");
            while (vvod != 0)
            {
                vvod = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (vvod)
                {
                    default:
                        {
                            Console.WriteLine("Введено неверное значение!\n");
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            WorkWithArray.ArrOut(i_arr_width, i_arr_height, out save_arr);
                            goto rel;
                        }
                    case 2:
                        {
                            WorkWithArray.MaxVal(save_arr, i_arr_width, i_arr_height, out i_maxval, out i_maxwidth, out i_maxheght);
                            Console.WriteLine("Максиматьное значение: " + (i_maxval) + " у элемента № " + (i_maxwidth + 1) + " " + (i_maxheght + 1) + "\n");
                            break;
                        }
                    case 3:
                        {
                            WorkWithArray.MinVal(save_arr, i_arr_width, i_arr_height, out i_minval, out i_minwidth, out i_minheight);
                            Console.WriteLine("Минимальное значение: " + (i_minval) + " у элемента № " + (i_minwidth + 1) + " " + (i_minheight + 1) + "\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Средне значение = " + WorkWithArray.Aver(save_arr, i_arr_width, i_arr_height) + "\n");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите число, которое хотите найти\n");
                            i_srnum = int.Parse(Console.ReadLine());
                            WorkWithArray.Search(save_arr, i_arr_width, i_arr_height, i_srnum, out i_srx, out i_sry);
                            if ((i_srx < 0) || (i_sry < 0))
                            {
                                Console.WriteLine("\nЗапрашиваемое число в данном массиве не найдено\n");
                            }
                            else
                            {
                                Console.WriteLine("\nПервое вхождение значения " + i_srnum + " обнаружено у элемента № " + (i_srx + 1) + " " + (i_sry + 1) + "\n");
                            }
                            break;
                        }
                }
            }

            //char[] ran_ch = { '0', '5', '&', '^' };
            //WorkWithArray wksort = new WorkWithArray();
            //ran_ch = wksort.Sort(ran_ch, false);

            //for(int i = 0; i < ran_ch.Length; i++)
            //{
            //    Console.WriteLine("[" + i + "] = " + ran_ch[i]);
            //}
            //Console.WriteLine(wksort.ToString());

            //Example ex = new Example();
            //ex.OverArr(ref ran_ch);
            //foreach(object value in ran_ch)
            //{
            //    Console.WriteLine(value);
            //}

            Console.ReadKey();
        }
     
    }

}
