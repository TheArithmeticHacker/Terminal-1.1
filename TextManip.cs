using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MPS_1
{

    internal class TextManip
    { 
        
        
        
        static private void OutputWor(string x)
        {
            char[] y = x.ToCharArray();
            foreach (char c in y)
            {
                Console.Write(c);
                int speedLetter = Int32.Parse(File.ReadAllText("Settings/letterspeed.txt"));
                Thread.Sleep(speedLetter);
            }
        }
        static public void Output(string Line)
        {
            String[] Words = Line.Split(' ');
            foreach (string word in Words)
            {
                int speedWord = Int32.Parse(File.ReadAllText("Settings/wordspeed.txt"));
                OutputWor(word);
                Console.Write(' ');
                Thread.Sleep(speedWord);
            }
            Console.WriteLine("");
        }

        static public string[] Input()
        {
            string x = Console.ReadLine().ToLower().Trim();
            string[] line = x.Split(' ');

            return line;
        }
    }
}
