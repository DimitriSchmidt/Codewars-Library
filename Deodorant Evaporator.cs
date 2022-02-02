using System;
namespace Codewars
{
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
