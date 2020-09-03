using System;
using System.Collections.Generic;
using System.Linq;

namespace IP_Adress
{
    class Program
    {


        static void Main(string[] args)
        {
            string start = "20.0.0.10";
            string end = "20.0.1.0";
            IpsBetween(start,end);
        }

        public static long IpsBetween(string start, string end)
        { 
          string [] first =  start.Split('.');
          string [] second = end.Split('.');
          string[] selected_Arr = { };
         
          var Result_first = "";
          var Result_second = "";
          int count = 0;

            while (count < 2)
            {
                count++;
                if (count == 1) { selected_Arr = first;}else{selected_Arr = second;}

                foreach (string ch in selected_Arr)
                {

                    var result = "";
                    long number = Convert.ToInt64(ch);
                    string b = "";

                    while (number > 0)
                    {
                        b = (number % 2) + b;
                        number = number / 2;
                        result = b;

                    }
                     if (result.Length < 8)
                        for (int i = result.Length; i < 8; i++)
                        {
                            result = "0" + result;
                        }
               
                   if(count==1){ 
                   Result_first = Result_first+result; 
                   }else
                   {Result_second = Result_second+ result;}
             
                   Console.Write(result);
                }
                   Console.WriteLine();
             
            }
            
            long searched_Number = Convert.ToInt64(Result_second, 2) - Convert.ToInt64(Result_first, 2);

            Console.WriteLine(searched_Number);
            Console.ReadKey();


            return searched_Number;
       
        }
    }
}
