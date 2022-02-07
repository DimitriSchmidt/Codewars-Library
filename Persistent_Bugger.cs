using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Persistent_Bugger
{
    class Persistent_Bugger
    {
        //Write a function, persistence,-
        //that takes in a positive parameter num and returns its multiplicative persistence,-
        //which is the number of times you must multiply the digits in num until you reach a single digit.



        //Example (input-->output)
        //39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
        //999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
        //4 --> 0 (because 4 is already a one-digit number)


        static void Main(string[] args)
        {
            long n =9999;
            Persist.Persistence(n);
        }

        public class Persist
        {
            public static byte[] digitsOfNumber = new byte[] { };
            public static Stack stack = new Stack();

            public static long Persistence(long n)
            {
      
                int num = 0; //wie oft wurde multipliziert
                int Buffer =1;

                //Convert integer to string & split the number in digits
                var Convert_number_toString = n.ToString();
                digitsOfNumber = Convert_number_toString.ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
                stack = new Stack(digitsOfNumber);

                //Check single digit
                while (stack.Count!=1)
                {    
                    while (stack.Count > 1)
                    {  
                        int value;
                        value = Convert.ToInt32(stack.ToArray()[0]) * Convert.ToInt32(stack.ToArray()[1]);
                        Buffer *= value;
                        stack.Pop();
                        stack.Pop();

                        if(stack.Count==1)
                        {
                            Buffer *= Convert.ToInt32(stack.ToArray()[0]);
                        }
                        Console.WriteLine(Buffer);
                    }
                    
                    num++;
                    
                   stack.Push(Converter(Buffer,num));
                   Buffer = 1;
                }

                Console.WriteLine(num);
                Console.ReadKey();
                return num; 
            }

            public static Array Converter (int Buffer,int num)
            {
              var Convert_number_toString = Buffer.ToString();
              byte[] Array = new byte[] { };
              Array = Convert_number_toString.ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
              stack = new Stack(Array);
              return Array;
            }
           

        }
      
    }
}
