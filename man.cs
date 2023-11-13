using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace MPS_1
{
    internal class Man
    {
        static public void man()
        {
            string y = File.ReadAllText("Text/help.txt");
            TextManip.Output(y);
        }
        
    }
}
