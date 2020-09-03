using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Codewarsx
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=10;
            Program.GetTurkishNumber(num);

        }

    
            public static string GetTurkishNumber(int num)
            {
               string[] Arr_First_Name = new string[] { "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            
               string[] Arr_Last_Name = new string[] { "sifir","bir","iki","üç","dört","beş", "altı", "yedi", "sekiz", "dokuz" };
        
                //two digits
                if (num.ToString().Length > 1)
                {

                    char num_firstdigit = num.ToString().First();
                    char num_lastdigit = num.ToString().Last();

                    int FirstNameIndex = int.Parse(num_firstdigit.ToString());
                    int LastNameIndex = int.Parse(num_lastdigit.ToString());

                    var First_Name = Arr_First_Name[FirstNameIndex - 1];
                    var Last_Name = Arr_Last_Name[LastNameIndex];

                    if (num.ToString().Length > 1 & num.ToString().Contains("0"))
                        return Arr_First_Name[num/10-1];
                    else
                        return First_Name + " " + Last_Name;

                }
          
         
                //one digit
                return Arr_Last_Name[num];
        
            }
    

           
        }
    }

