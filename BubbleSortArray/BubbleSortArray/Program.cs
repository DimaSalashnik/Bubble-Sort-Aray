using System;

namespace BubbleSortArray
{
    class Program
    {
        static int[] array = new int[5];

        static void Main(string[] args)
        {
            Process();
        }
        static void Process()
        {
            Console.WriteLine("Хотите отсортировать массив? (да/нет)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "да" || answer == "yes")
                FillArray();
            else if (answer == "нет" || answer == "no")
            { Console.WriteLine("Завершение работы..."); return; }
            else
            { Console.WriteLine("Повторите попытку..."); Process(); }
        }
        static void FillArray()
        {
            Console.WriteLine("Сколько должно быть чисел в массиве?");
            try {int arrayLength = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref array, arrayLength);}
            catch { Console.WriteLine("Повторите попытку..."); FillArray(); return; }
            Console.WriteLine("Введите по порядку числа через Enter");
            for (int q = 0; q < array.Length; q++){
                try { array[q] = Convert.ToInt32(Console.ReadLine()); }
                catch { Console.WriteLine("Повторите попытку..."); q--; }
            }
            BubleSort();
        }
        static void BubleSort()
        {
            int temp;
            int l = array.Length;
            for (int q = 0; q < l - 1; q++){
                for (int j = 0; j < l - q - 1; j++){
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
            }   }   }
            PrintArray();
        }
        static void PrintArray()
        {
            Console.WriteLine("Отсортированный массив: ");
            foreach (int num in array)
                Console.WriteLine(num);
            Process();
        }
    }
}
