using System;
using Mono.Cecil;

namespace CecilMethodFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var argumentsInfo = new ArgumentsInfo(args);
            var printer = new Printer();

            if (!argumentsInfo.IsValid())
            {
                printer.PrintInvalidArguments();
            }

            ModuleDefinition module;

            var modulePath = argumentsInfo.GetModulePath();

            try
            {
                module = ModuleDefinition.ReadModule(modulePath);
            }
            catch (Exception e)
            {
                printer.PrintError(e.Message);
                return;
            }

            var methodsFinder = new MethodsFinder();

            var methodName = argumentsInfo.GetMethodName();

            foreach (var method in methodsFinder.GetMethods(module, methodName))
            {
                printer.PrintLine(method.FullName);
            }
        }
    }
}
