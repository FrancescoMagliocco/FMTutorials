namespace FMTutorials.MultilayeredDll.DependencyDll
{
    using System;

    public static class LibDependency
    {        
        public static void Info(string strfmt, params object[] args)
        {
            Console.Write("Info:\t");
            Console.WriteLine(strfmt, args);
        }

        public static void Warning(string strfmt, params object[] args)
        {
            Console.Write("Warning:\t");
            Console.WriteLine(strfmt, args);
        }

        public static void Error(string strfmt, params object[] args)
        {
            Console.Write("Error:\t");
            Console.WriteLine(strfmt, args);
        }
    }
}
