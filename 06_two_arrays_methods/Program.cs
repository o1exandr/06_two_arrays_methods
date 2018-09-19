/*
 6. Визначити методи для роботи з одновимірним масивом
	- отримує 2 одновимірні масиви та повертає масив з спільними елементами(без повторів)
	- отримує 2 одновимірні масиви та повертає масив, що містить елементи першого масиву, що НЕ зустрічаються у другому 
Скористатися  Contains, IndexOf чи ін.
 */


using System;
using System.Linq;

namespace _06_two_arrays_methods
{
    class Program
    {
        // друк масиву
        static void Print(int[] arr, string message = "")
        {
            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}\t");
            Console.WriteLine("\n");
        }

        // додавання елементу в масив
        static void AppendElemToArray(ref int[] arr, int element)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = element;
        }

        // отримує 2 одновимірні масиви та повертає масив з спільними елементами(без повторів)
        static int [] Common(int[] one, int[] two)
        {
            int[] commonArr = new int[0];

            for (int i = 0; i < one.Length; ++i)
            {
                if (two.Contains(one[i]) && !commonArr.Contains(one[i]))
                    AppendElemToArray(ref commonArr, one[i]);
            }
            return commonArr;
        }

        // отримує 2 одновимірні масиви та повертає масив, що містить елементи першого масиву, що НЕ зустрічаються у другому 
        static int[] Unique(int[] one, int[] two)
        {
            int[] uniqueArr = new int[0];

            for (int i = 0; i < one.Length; ++i)
            {
                if(!two.Contains(one[i]) && !uniqueArr.Contains(one[i]))
                    AppendElemToArray(ref uniqueArr, one[i]);
            }
            return uniqueArr;
        }

        static void Main(string[] args)
        {
            int[] one = { 1, 3, 5, 7, 7, 9, 21 };
            int[] two = { 7, 9, 11, 13, 15, 17 };

            Print(one, "Array One:");
            Print(two, "Array Two:");
            int[] three = Common(one, two);
            Print(three, "Array with common elements:");
            three = Unique(one, two);
            Print(three, "Array with unique elements from first array:");
        }
    }
}
