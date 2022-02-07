using System;
namespace Codewars
{
//This program tests the life of an evaporator containing a gas.
//We know the content of the evaporator (content in ml), the percentage of foam or gas lost every day (evap_per_day) and -  
//the threshold (threshold) in percentage beyond which the evaporator is no longer useful. 
//All numbers are strictly positive.
//The program reports the nth day (as an integer) on which the evaporator will be out of use.
// Example: evaporator(10, 10, 5) -> 29 days


We know the content of the evaporator (content in ml), the percentage of foam or gas lost every day (evap_per_day) and the threshold (threshold) in percentage beyond which the evaporator is no longer useful. All numbers are strictly positive.

The program reports the nth day (as an integer) on which the evaporator will be out of use.    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Evaporator.evaporator();
        }

        public class Evaporator
        {
            public static int evaporator(double content=10, double evap_per_day=20, double threshold=10)
            {
                double lose_ml_per_day = 0;
                int count = 0;
                double content_finaly =(threshold/100)*content;
                
                while(content > content_finaly)
                {
                  lose_ml_per_day = (content / 100)*evap_per_day;
                  content-=lose_ml_per_day;
                  count++;
                }
                return count;

            }
        }
    }
}
