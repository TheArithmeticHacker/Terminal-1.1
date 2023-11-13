using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_1
{
    internal class Set
    {
        public static void setting(string[] x) 
        {
            if (x.Length == 1)
            {
                string y = File.ReadAllText("Text/Manual/set.txt");
                TextManip.Output(y);
            } else if (x.Length >= 4 || x.Length == 2)
            {
                TextManip.Output("Error: Wrong type/number of arguments");
            } else if (x.Length == 3)
            {
                if (x[1] == "letspd")
                {
                    int number = 0;
                    if (Int32.TryParse(x[2], out number) && Int32.Parse(x[2]) >= 0)
                    {
                        File.WriteAllText("Settings/letterspeed.txt", x[2]);
                    }
                    else
                    {
                        TextManip.Output("Error: Wrong type/number of arguments");
                    }
                } else if (x[1] == "wrdspd")
                {
                    int number = 0;
                    if (Int32.TryParse(x[2], out number) && Int32.Parse(x[2]) >= 0)
                    {
                        File.WriteAllText("Settings/wordspeed.txt", x[2]);
                    }
                    else
                    {
                        TextManip.Output("Error: Wrong type/number of arguments");
                    }
                }else if (x[1] == "fg")
                {
                    ConsoleColor c;
                    try
                    {
                        c = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), x[2], true);
                        if (Console.BackgroundColor == c)
                        {
                            TextManip.Output("Can't Change Font Color to Background Color");
                        }
                        else
                        {
                            File.WriteAllText("Settings/Foreground color.txt", x[2]);
                            Console.ForegroundColor = c;
                            Console.Clear();
                        }
                        
                    }
                    catch (Exception)
                    {
                        TextManip.Output("Error: Wrong type/number of arguments");
                    }
                }
                else if (x[1] == "bg")
                {
                    ConsoleColor c;
                    try
                    {
                        c = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), x[2], true);
                        if(Console.ForegroundColor == c)
                        {
                            TextManip.Output("Can't Change Background Color to Font Color");
                        }
                        else
                        {
                            File.WriteAllText("Settings/Background color.txt", x[2]);
                            Console.BackgroundColor = c;
                            Console.Clear();
                        }
                    }
                    catch (Exception)
                    {
                        TextManip.Output("Error: Wrong type/number of arguments");
                    }
                }
                else
                {
                    TextManip.Output("Error: Wrong type/number of arguments");
                }
            }
        }
    }
}
