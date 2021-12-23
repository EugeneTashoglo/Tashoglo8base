using System;

namespace Tashoglo8base
{
    class Program
    {
        static void Main()                 
        {
             //1
                Console.WriteLine("Введите время:");
                TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time);
                Console.WriteLine($"Часы - {time.Hours}\nМинуты - {time.Minutes}\nСекунды - {time.Seconds}\nМиллисекунды - {time.Milliseconds}");                    
                Console.Write("Введите время будильника: ");
            //2
                TimeSpan timeNow = DateTime.Now.TimeOfDay;
                Console.WriteLine(timeNow >= time ? $"Будильник зазвенит через - {TimeSpan.FromHours(24).Subtract((timeNow.Subtract(time))).ToString(@"hh\:mm\:ss")}"
                : $"Будильник зазвенит через - {timeNow.Subtract(time).ToString(@"hh\:mm\:ss")}");           
        }        
    }
}