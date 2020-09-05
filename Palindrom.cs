
using System.Diagnostics;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
       
            string s = "hannahx";
            Debug.Print(s);
            solve(s);
        }


        public static string solve(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - (i + 1)])
                {
                    //good news
                }
                else
                {
                 //bad news
                 Debug.Print (Check(s));
                 return Check(s);
                }
            }
            Debug.Print("OK");
            return "OK";
        }

        public static string Check(string s)
        {
         string copy = s;
         for (int i = 0; i < s.Length; i++)
         {
            copy = s.Remove(i, 1);
            if (Remove_check(copy))
            {
             Debug.Print(copy);
             return "remove one";
            }
            else{}
          }

            Debug.Print(copy);
            return "not possible";
        }

        public static bool Remove_check(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - (i + 1)])
                {
                    //good news
                }
                else
                {
                    //bad news
                    return false;
                }
            }
            Debug.Print("remove one");
            return true;
        }
    }      
}
