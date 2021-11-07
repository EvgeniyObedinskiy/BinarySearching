using System;


namespace ConsoleApp3
{
    class Program
    {
       
        public static string BinarySearch(int[] arr, int item)
        {
            ///Длинна поиска в массиве.
            var arrLength = arr.Length;
            ///Начало поиска в массиве
            var arrStart = 0;
            ///Цикл работает пока поиск не сузиться до значения искомого элемента.
            while (arrStart <= arrLength) 
            {
                ///Середина массива.
                var arrMid = (arrStart + arrLength) / 2;
                ///Значение элемента середины массива. 
                var midItem = arr[arrMid];

                if (midItem == item) 
                {   ///Если зачение элемента середины массива равна искомому, возвращаем индекс.
                    return arrMid.ToString();
                }
                if (midItem > item)
                {   ///Если зачение элемента середины массива больше искомого, длинна поиска равна середине массива -1.
                    arrLength = arrMid - 1;
                }
                else
                    ///Иначе начало поиска в массиве равна середине массива +1.
                    arrStart = arrMid + 1;
            }
            return "Not found";
            
        }
        static void Main(string[] args) 
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123 };
            string res = BinarySearch(arr, 5);
            Console.WriteLine(res);
            Console.ReadLine();

        }

    }
}
