using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_1
{
    internal class Object
    {
        public static void classes(string x)
        {
            string y;
            switch (x)
            {
                case "utilis":
                    y = File.ReadAllText("Text/Object Class/Utilis.txt");
                    TextManip.Output(y);
                    break;
                case "otium":
                    y = File.ReadAllText("Text/Object Class/Otium.txt");
                    TextManip.Output(y);
                    break;
                case "khatar":
                    y = File.ReadAllText("Text/Object Class/Khatar.txt");
                    TextManip.Output(y);
                    break;
                case "aisthima":
                    y = File.ReadAllText("Text/Object Class/Aisthima.txt");
                    TextManip.Output(y);
                    break;
                default:
                    TextManip.Output("Class not found in databse");
                    break;
            }


        }
    }
}
