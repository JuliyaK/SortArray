using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sort_Array
{

    public class SortArray
    {
        static void Main()
        { 
             Console.WriteLine("Исходный массив объектов");
             char[] array = { 'с', 'с', 'з', 'с', 'к', 'з', 'з', 'з', 'к', 'к', 'с', 'з', 'с', 'с', 'к', 'з' };
             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine(array[i]);
             }

             Console.WriteLine("Отсортированный массив объектов");
             char[] sort_array = Sort(array);

             for (int i = 0; i < sort_array.Length; i++)
             {
                 Console.WriteLine(sort_array[i]);
             }
            
            Console.ReadLine();
        }
        //Присваиваем символу номер
        public static int Transform (char arg)
        {
            if (arg == 'з')
            {
                return 1;
            }
            if (arg == 'с')
            {
                return 2;
            }
            if (arg == 'к')
            {
                return 3;
            }
            return 0;
        }
        //Сортировка пузырьком
        public static char[] Sort(char[] arr)
        {
            char temp;
            for (int j = 0; j < arr.Length; j++)
            {
                
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int v1 = Transform(arr[i]); 
                    int v = Transform(arr[i+1]);

                    if (v < v1)
                    {
                        temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;
                    }
                }
            }
            return arr;

        }

    }

}

