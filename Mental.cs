using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_1
{
    internal class Mental
    {
        public static void classes(string x)
        {
            string y;
                switch (x)
                {
                    case "nirvana":
                        y = File.ReadAllText("Text/Mental Class/Nirvana.txt");
                        TextManip.Output(y);
                        break;
                    case "seijo":
                        y = File.ReadAllText("Text/Mental Class/Seijo.txt");
                        TextManip.Output(y);
                        break;
                    case "pascallete":
                        y = File.ReadAllText("Text/Mental Class/Pascallete.txt");
                        TextManip.Output(y);
                        break;
                    case "astray":
                        y = File.ReadAllText("Text/Mental Class/Astray.txt");
                        TextManip.Output(y);
                        break;
                    case "infernum":
                        Console.ForegroundColor = ConsoleColor.Red;
                        y = File.ReadAllText("Text/Mental Class/INFERNUM_quote.txt");
                        TextManip.Output(y);
                        Console.ForegroundColor = ConsoleColor.White;
                        y = File.ReadAllText("Text/Mental Class/INFERNUM_speech.txt");
                        TextManip.Output(y);
                        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), File.ReadAllText("Settings/Foreground color.txt"), true);
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), File.ReadAllText("Settings/Background color.txt"), true);
                        break;
                    default:
                        TextManip.Output("Class not found in database");
                        break;
                }
   

        }
    }
}
