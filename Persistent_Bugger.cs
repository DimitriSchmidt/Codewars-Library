using System;
using System.Collections;
using System.Linq;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence,
/// which is the number of times you must multiply the digits in num until you reach a single digit.

/// For example (Input --> Output):
/// 39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
/// 999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
/// 4 --> 0 (because 4 is already a one-digit number)
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


public class Persist 
{
  public static int Persistence(long n) 
  {
    int num = 0;
    int Buffer = 1;
    Stack stack = new Stack(n.ToString().Select(ch => ch - '0').ToArray()); 
    
    while (stack.Count!=1)
    {
      while (stack.Count > 1)
      {
        int value;
        value =(int)stack.ToArray()[0] * (int)stack.ToArray()[1];
        Buffer *= value;
        stack.Pop();
        stack.Pop();
        if(stack.Count==1){Buffer *= (int)(stack.ToArray()[0]);}
        
      }
      num++;
      stack = new Stack(Buffer.ToString().Select(ch => ch - '0').ToArray());
      Buffer = 1;
    }
   return num;
  }
}
