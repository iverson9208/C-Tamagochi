using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(5));
        }
        public static List<string> stringg (){
            
            List<string> list = new List<string>();
            list.Add("Покормить");
            list.Add("Погулять");
            list.Add("Уложить спать");
            list.Add("Полечить");
            list.Add("Поиграть");
            return list;
            }
        static void Main(string[] args)
        {
            message del = new message(color);
            str stri = new str(stringg);
            List<string> c = stri();
            Random rnd = new Random();
                int t = rnd.Next(0,5);
                c[t].ToString();
                Console.WriteLine(c[t].ToString());
            
        }
        public delegate void message();
        public delegate List<string> str();
        
        public static void color()
        {
            Console.ForegroundColor = GetRandomConsoleColor();
        }

     
    }
}
