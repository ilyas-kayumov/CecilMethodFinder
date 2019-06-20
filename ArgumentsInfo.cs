using System;

namespace CecilMethodFinder
{
    public class ArgumentsInfo
    {
        private readonly string[] arguments;

        public ArgumentsInfo(string[] args)
        {
            this.arguments = args;
        }

        public bool IsValid()
        {
            return arguments.Length >= 2;
        }

        public string GetModulePath()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException();
            }

            return arguments[0];
        }

        public string GetMethodName()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException();
            }

            return arguments[1];
        }
    }
}
