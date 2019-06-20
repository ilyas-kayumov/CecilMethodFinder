using System;

namespace CecilMethodFinder
{
    public class Printer
    {
        public void PrintInvalidArguments()
        {
            PrintLine("Invalid number of arguments");
        }

        public void PrintError(string message)
        {
            PrintLine($"Error: {message}");
        }

        public void PrintLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
