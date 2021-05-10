using System;
using System.Reflection;

namespace Immas.Common
{
    public class AssemblyUtil
    {
        public static object CreateInstance(string assemblyName, string typeName)
        {
            Assembly assembly = Assembly.Load(assemblyName);
            Type type = assembly.GetType(typeName);
            return Activator.CreateInstance(type);
        }
        public static T CreateInstance<T>(string assemblyName, string typeName)
        {
            return (T)CreateInstance(assemblyName, typeName);
        }

        public static object CreateInstance(string assemblyName, string typeName, params object[] args)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyName);
            Type type = assembly.GetType(typeName);
            return Activator.CreateInstance(type, args);
        }
        public static T CreateInstance<T>(string assemblyName, string typeName, params object[] args)
        {
            return (T)CreateInstance(assemblyName, typeName, args);
        }
    }
}
