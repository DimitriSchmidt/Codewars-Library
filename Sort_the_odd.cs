using System;
using System.Diagnostics;
using System.Linq;
namespace Sort_the_odd
{
    // You will be given an array of numbers (Digits and Numbers).
    // You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
    //             Array with digits Exemaple & sorted Example
    //             true: 1, 3, 2, 8, 5, 4 => 5, 3, 2, 8, 1, 4
    //             true: 1, 3, 5, 8, 0 => 5, 3, 1, 8, 0 
    //             true: 1, 8, 6, 3, 4 => 3, 8, 6, 1 , 4



    class Program
    {
        static void Main(string[] args)
        {
           
           int[] Arr = new int[] { 1, 3, 2, 8, 5, 4 };
       
           Kata.SortArray(Arr);
          
        }

        public class Kata
        {
           
            public static int[] SortArray(int[] Arr)
            {
                Console.WriteLine(string.Join(",", Arr));
                int[] BufferValue_odd_numbers = new int[] { };
                int[] BufferIndexOf_odd_numbers = new int[] { };
                int iCounter_index = 0;

                //Array wird auf gerade/ungerade Zahl selektiert. 
                //Index von ungerade Zahlen wird zwischengespeichert in []BufferIndexOf_odd_numbers & aktueller Wert in [] BufferValue_odd_numbers gespeichert.
                foreach (int element in Arr)
                {
                   if (element % 2 != 0)
                   {
                     BufferValue_odd_numbers = BufferValue_odd_numbers.Append(element).ToArray();
                     BufferIndexOf_odd_numbers = BufferIndexOf_odd_numbers.Append(iCounter_index).ToArray();
                
                     Console.WriteLine(element + " = digit ist odd");
                   }

                    iCounter_index++;
                }

              //Array mit ungeraden sortieren "ascending"
              Array.Sort(BufferValue_odd_numbers);
              Array.Reverse(BufferValue_odd_numbers);

                //Sortierte Werte in [] BufferValue_odd_numbers in Ausgangs Array einfügen, dabei wird index von [] BufferIndexOf_odd_numbers zugewiesen
                for (int index = 0; index < BufferIndexOf_odd_numbers.Length; index++) 
                {
                  Arr[BufferIndexOf_odd_numbers[index]] = BufferValue_odd_numbers[index];
                }

                Console.WriteLine(string.Join(",", Arr));
                Console.ReadKey();

                return Arr;
            }
        }
    }

    
}
