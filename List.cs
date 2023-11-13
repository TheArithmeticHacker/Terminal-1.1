using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_1
{
    internal class List
    {
        public static void Ls(string[] x)
        {
            if (x.Length == 2)
            {
                switch (x[1])
                {
                    case "mps":
                        MPS.list();
                        break;
                    case "mental":
                        string[] mentalClasses = {"Nirvana", "Seijo", "Pascallete", "Astray", "INFERNUM" };
                        foreach(string mentalClass in mentalClasses) {
                            if(mentalClass == "INFERNUM") {
                                Console.ForegroundColor = ConsoleColor.Red;
                                TextManip.Output(mentalClass);
                                string color1 = File.ReadAllText("Settings/Foreground color.txt");
                                try
                                {
                                    ConsoleColor c = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color1, true);
                                    Console.ForegroundColor = c;
                                }
                                catch (Exception) { }
                            }else
                            {
                                TextManip.Output(mentalClass);
                            } 
                        }
                        break;
                    case "object":
                        string[] objectClasses = { "Utilis", "Otium", "Khatar", "Aisthima"};
                        foreach (string objectClass in objectClasses)
                        {
                            TextManip.Output(objectClass);
                        }
                        break;
                    case "report":
                        string[] reports = Directory.GetFiles("Text/Report/");
                        foreach (string reportsFile in reports)
                        {
                            string report = reportsFile.Substring(12);
                            TextManip.Output(report);
                        }
                        break;
                    default:
                        TextManip.Output("Error: There are no lists on that topic in the database");
                        break;
                }
            }
            else
            {
                TextManip.Output("Error: Wrong type/number of arguments");
            }
        }
    }
}
