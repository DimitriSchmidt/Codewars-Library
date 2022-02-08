using System;
using System.Collections;
using System.Linq;

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
