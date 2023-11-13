using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_1
{
    internal class Report
    {
        public static void ReportEvent(string[] x)
        {
            DateTime CurrentDate = DateTime.Now;
            String currentDate = CurrentDate.ToString("yyyy-MM-dd");
            String CurrentDatePath = "Text/Report/" + currentDate + ".txt";
            if(x.Length == 1)
            {
                bool exit = true;
                string y = CurrentDate.ToString("HH:mm");
                do
                {
                    if (y == "!q")
                    {
                        exit = false;
                    }
                    else
                    {
                        File.AppendAllText(CurrentDatePath, y + Environment.NewLine);
                        y = Console.ReadLine();
                    }
                } while (exit);
            }
            else
            {
                TextManip.Output("Error: Wrong type/number of arguments");
            }
        }
        public static void ReportAccess(string x, bool y)
        {
            if(y)
            {
                if (IsDateFormatValid(x, "yyyy-MM-dd"))
                {
                    bool reportExists = false;
                    x += ".txt";
                    string[] reports = Directory.GetFiles("Text/Report/");
                    foreach (string reportsFile in reports)
                    {
                        string report = reportsFile.Substring(12);
                        if (x == report)
                        {
                            reportExists = true;
                            break;
                        }
                    }
                    if (reportExists)
                    {
                        TextManip.Output(File.ReadAllText("Text/Report/" + x));
                        string InputtedText = "";
                        bool exit = true;
                        do
                        {
                            InputtedText = Console.ReadLine();
                            if (InputtedText == "!q")
                            {
                                exit = false;
                            }
                            else
                            {
                                File.AppendAllText("Text/Report/" + x, InputtedText + Environment.NewLine);
                            }
                        } while (exit);
                    }
                    else
                    {
                        TextManip.Output("This report does not exist. Would you like to create one? (Y/N)");
                        string answer = TextManip.Input()[0];
                        if (answer == "y")
                        {
                            string InputtedText = "";
                            bool exit = true;
                            do
                            {
                                InputtedText = Console.ReadLine();
                                File.AppendAllText("Text/Report/" + x, InputtedText + Environment.NewLine);
                                if (InputtedText == "!q") exit = false;
                            } while (exit);
                        }else if(answer == "n")
                        {

                        }
                        else
                        {
                            TextManip.Output("Error: Unidentified Response");
                        }
                    }
                }
                else
                {
                    TextManip.Output("Error: Wrong Date Format");
                }
            }
            else
            {
                if(IsDateFormatValid(x, "yyyy-MM-dd"))
                {
                    bool reportExists = false;
                    x += ".txt";
                    string[] reports = Directory.GetFiles("Text/Report/");
                    foreach (string reportsFile in reports)
                    {
                        string report = reportsFile.Substring(12);
                        if(x == report)
                        {
                            reportExists = true;
                            break;
                        }
                    }
                    if(reportExists)
                    {
                        TextManip.Output(File.ReadAllText("Text/Report/" + x));
                    }
                    else
                    {
                        TextManip.Output("This report does not exist. Would you like to create one? (Y/N)");
                        string answer = TextManip.Input()[0];
                        if(answer == "y")
                        {
                            string InputtedText = "";
                            bool exit = true;
                            do
                            {
                                InputtedText = Console.ReadLine();
                                if (InputtedText == "!q")
                                {
                                    exit = false;
                                }
                                else
                                {
                                    File.AppendAllText("Text/Report/" + x, InputtedText + Environment.NewLine);
                                }
                            } while (exit);
                        }else if (answer == "n")
                        {

                        }
                        else
                        {
                            TextManip.Output("Error: Unidentified Response");
                        }
                    }
                }
                else
                {
                    TextManip.Output("Error: Wrong Date Format");
                }
            }
        }
        static bool IsDateFormatValid(string input, string dateFormat)
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(input, dateFormat, null, System.Globalization.DateTimeStyles.None, out parsedDate);
        }
    }
}


