using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp{
    class Program{
        static int[] nums;
        static void Main(string[] args){
            Choose();
        }
        //Набор операций для повторной сортировки
        private static void OperationKit()
        {
            try { FillArray(); }
            catch { FillArray(); }
            SortArray();
            OArray();
            Choose();
        } 
        private static void Choose()
        {
            Console.WriteLine("Хотите отсортировать массив? (да/нет)");
            string w = Console.ReadLine().ToLower();
            if (w == "да" || w == "yes"){
                Console.WriteLine("Введите количество чисел для сортировки");
                Array.Resize(ref nums, Convert.ToInt32(Console.ReadLine()));
                OperationKit();}
            else Console.WriteLine("Завершение работы...");
        }
        //Заполнение массива вручную
        private static void FillArray()
        {
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < nums.Length; i++){
                try{
                    Console.Write("{0}-е число: ", i + 1);
                    nums[i] = Int32.Parse(Console.ReadLine());}
                catch { Console.WriteLine("Повторите еще раз"); i--; }
        }   }

        //Сортировка массива
        private static void SortArray()
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] > nums[j]) {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
        }   }   }   }

        //Вывод массива
        private static void OArray()
        {
            Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < nums.Length; i++)
                    Console.WriteLine(nums[i]);
        }
    }
}
