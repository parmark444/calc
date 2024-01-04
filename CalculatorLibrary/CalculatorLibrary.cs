using System;
using System.Diagnostics;
using System.IO;
namespace CalculatorLibrary
{
    public class Calc
    {
        public Calc()
        {
            StreamWriter logFile = File.CreateText("calc.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Your Calculator log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double DoOperation(double x, double y, string operation)
        {
            double result = double.NaN;
            switch (operation)
            {
                case "add":
                    result = x + y;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", x, y, result));
                    break;
                case "sub":
                    result = x - y;
                    Trace.WriteLine(String.Format("{0} - {1} = {2}", x, y, result));
                    break;
                case "mult":
                    result = x * y;
                    Trace.WriteLine(String.Format("{0} * {1} = {2}", x, y, result));
                    break;
                case "div":
                    if (y != 0)
                    {
                        result = x / y;
                        Trace.WriteLine(String.Format("{0} / {1} = {2}", x, y, result));
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }


}
