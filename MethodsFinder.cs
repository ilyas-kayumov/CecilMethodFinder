using System.Collections.Generic;
using Mono.Cecil;

namespace CecilMethodFinder
{
    public class MethodsFinder
    {
        public IEnumerable<MethodDefinition> GetMethods(ModuleDefinition module, string methodName)
        {
            foreach (TypeDefinition type in module.Types) 
            {
                foreach (var method in type.Methods)
                {
                    if (method.FullName.Contains(methodName))
                    {
                        yield return method;
                    }
                }
            }
        }
    }
}
