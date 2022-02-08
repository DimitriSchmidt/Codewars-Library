using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Persist
{

    public static byte[] digitsOfNumber = new byte[] { };
    public static Stack stack = new Stack();

    public static int Persistence(long n)
    {
        int num = 0; //wie oft wurde multipliziert
        int Buffer = 1;

        //Convert integer to string & split the number in digits
        var Convert_number_toString = n.ToString();
        digitsOfNumber = Convert_number_toString.ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
        stack = new Stack(digitsOfNumber);

        //Check single digit
        while (stack.Count != 1)
        {
            while (stack.Count > 1)
            {
                int value;
                value = Convert.ToInt32(stack.ToArray()[0]) * Convert.ToInt32(stack.ToArray()[1]);
                Buffer *= value;
                stack.Pop();
                stack.Pop();

                if (stack.Count == 1) { Buffer *= Convert.ToInt32(stack.ToArray()[0]); }
            }

            num++;
            stack.Push(Converter(Buffer, num));
            Buffer = 1;
        }

        return num;
    }
    public static Array Converter(int Buffer, int num)
    {
        var Convert_number_toString = Buffer.ToString();
        byte[] Array = new byte[] { };
        Array = Convert_number_toString.ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
        stack = new Stack(Array);
        return Array;
    }
}