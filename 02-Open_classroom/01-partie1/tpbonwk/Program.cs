using System;

namespace tpbonwk
{
    class Program
    {
        static void message()
        {
            string userName = System.Environment.UserName;
            DateTime timeNow = DateTime.Now;
            if (timeNow.DayOfWeek.ToString() == "Saturday" || timeNow.DayOfWeek.ToString() == "Sunday")
            {
                Console.WriteLine($"Bon weekend {userName}");
            }
            else 
            {   
                if (timeNow.Hour > 9 && timeNow.Hour < 18)
                {
                    Console.WriteLine($"Bonjour {userName}");
                }
                else
                {
                     Console.WriteLine($"Bonsoir {userName}");
                }            
            }
        }
        static void Main(string[] args)
        {
            message();
        }
    }
}
