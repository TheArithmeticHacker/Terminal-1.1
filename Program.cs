using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using Colorify;
using Newtonsoft.Json.Linq;


namespace MPS_1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string color1 = File.ReadAllText("Settings/Foreground color.txt");
            try
            {
                ConsoleColor c = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color1, true);
                Console.ForegroundColor = c;
            }catch (Exception){}
            string color2 = File.ReadAllText("Settings/Background color.txt");
            try
            {
                ConsoleColor c = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color2, true);
                Console.BackgroundColor = c;
            }
            catch (Exception) { }
            Console.Clear();
            
            bool exit = true; // The condition for when the user exits the loop
            string[] x; // The x that will determine the command the user chose
            TextManip.Output("Welcome to the MPS network!");
            TextManip.Output("You can access the latest updates from this console.");
            TextManip.Output("Type \"man\" for the manual");
            do
            {
                Console.Write(">");
                x = TextManip.Input();
                if (x[0] == "exit" || x[0] == "quit")
                {
                    exit = false;
                } else if (x[0] == "")
                {

                } else if (x[0] == "man")
                {
                    Man.man();
                } else if (x[0] == "open") 
                {
                    Open.OpenFile(x);
                } else if (x[0] == "report")
                {
                    Report.ReportEvent(x);
                } else if (x[0] == "set")
                {
                    Set.setting(x);
                } else if (x[0] == "clear")
                {
                    Console.Clear();
                } else if (x[0] == "ls")
                {
                    List.Ls(x);
                } else
                {
                    TextManip.Output("Error: Unidentified Command");
                }

                
            } while (exit);
        }
    }
}
