using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_1
{
    internal class Open
    {
        static public void OpenFile(string[] x)
        {
            if (x.Length == 1)
            {
                TextManip.Output("Error: Wrong type/number of arguments");
            }else if (x.Length == 2 && x[1] == "founder") 
            {
                string y = File.ReadAllText("Text/The Founder's Note.txt");
                ConsoleColor currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                TextManip.Output(y);
                Console.ForegroundColor= currentColor;
            }else if(x.Length == 3)
            {
                switch (x[1])
                {
                    case "mps":
                        MPS.mps(x[2]);
                        break;
                    case "mental":
                        Mental.classes(x[2]);
                        break;
                    case "report":
                        Report.ReportAccess(x[2], false);
                        break;
                    case "object":
                        Object.classes(x[2]);
                        break;
                }
            }else if (x.Length == 4 && x[3] == "-a") 
            {
                Report.ReportAccess(x[2], true);
            }
            else
            {
                TextManip.Output("Error: Wrong type/number of arguments");
            }
        }
    }
}
