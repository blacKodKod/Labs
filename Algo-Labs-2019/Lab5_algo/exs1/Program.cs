using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace exs1
{
    class Program
    {

        static public void PrintArr(IEnumerable<int> arr)
        {
            int i = 0;
            foreach (var item in arr)
            {
                Console.Write(item + " ");
                i++;
            }
            Console.WriteLine();
        }

        static public void DisplayTime(TimeSpan time, string info)
        {
            Console.WriteLine(info + " - " + time.TotalMilliseconds + "мс");
        }

        static public List<int> ShellStepCalculator(int arrSize, out int listSize)
        {
            List<int> steps = new List<int>();
            steps.Add(1);
            int i;
            for (i = 1; steps[i - 1] * 3 < arrSize; i++)
            {
                if ((arrSize % 2) == 0)
                    steps.Add(9 * (int)Math.Pow(2, i) - 9 * (int)Math.Pow(2, i / 2) + 1);
                else
                    steps.Add(8 * (int)Math.Pow(2, i) - 6 * (int)Math.Pow(2, (i + 1) / 2) + 1);
            }
            listSize = i - 1;
            return steps;
        }



        static void Main(string[] args)
        {
            int size;
            Console.Write("Введите размер массива: ");
            while (!int.TryParse(Console.ReadLine(), out size));

            //Structure Generator
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(size / 1);
            }
            int[] arr1, arr2;
            arr1 = new int[size];
            arr2 = new int[size];
            Array.Copy(arr, arr1, size);
            Array.Copy(arr, arr2, size);

            List<int> list = arr.ToList<int>();
            /*
            PrintArr(arr);
            PrintArr(arr1);
            PrintArr(list);
            PrintArr(arr2);
            */
            //----

            Console.WriteLine();
            Console.WriteLine("Время сортировки:");

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            //Сортировка выбором (массив)
            for (int i = 0, min, minInd = -1, temp; i < size - 1; i++)
            {
                min = int.MaxValue;
                for (int j = i; j < size; j++)
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minInd = j;
                    }

                temp = arr[i];
                arr[i] = arr[minInd];
                arr[minInd] = temp;
            }
            stopwatch.Stop();
            DisplayTime(stopwatch.Elapsed, "Сортировка выбором (массив)");

            stopwatch.Restart();

            //Сортировка вставками (массив)
            for (int i = 1; i < size; i++)
                for (int j = i, temp; j > 0; j--)
                {
                    if (arr1[j] < arr1[j - 1])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j - 1];
                        arr1[j - 1] = temp;
                    }
                    else
                        break;
                }
            stopwatch.Stop();
            DisplayTime(stopwatch.Elapsed, "Сортировка вставками (массив)");

            stopwatch.Restart();

            //Сортировка вставками (двусвязный список)
            for (int i = 1, temp; i < size; i++)
            {
                temp = list[i];
                list.RemoveAt(i);

                for (int j = i; j > 0; j--)
                {
                    if ((j - 1) == 0 && temp < list[0])
                    {
                        list.Insert(0, temp);
                        break;
                    }

                    if (temp >= list[j - 1])
                    {
                        list.Insert(j, temp);
                        break;
                    }
                }
            }
            stopwatch.Stop();
            DisplayTime(stopwatch.Elapsed, "Сортировка вставками (двусвязный список)");

            stopwatch.Restart();

            //Сортировка Шелла (массив)
            List<int> steps = ShellStepCalculator(arr2.Length, out int listSize);
            for (int step; listSize >= 0; listSize--)
            {
                step = steps[listSize];

                for (int i = step, temp; i < arr2.Length; i++)
                {
                    for (int j = i; j - step >= 0 && arr2[j - step] > arr2[j]; j -= step)
                    {
                        temp = arr2[j - step];
                        arr2[j - step] = arr2[j];
                        arr2[j] = temp;
                    }
                }
            }
            stopwatch.Stop();
            DisplayTime(stopwatch.Elapsed, "Сортировка Шелла (массив)");
            /*
            Console.WriteLine();
            Console.WriteLine("Результат:");
            PrintArr(arr);
            PrintArr(arr1);
            PrintArr(list);
            PrintArr(arr2);
            */
            Console.ReadKey();
        }
    }
}
