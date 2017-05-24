namespace FMTutorials.Tester
{
    using System;

    using Math = FMTutorials.MultilayeredDll.MainDll.LibMain;

    public class MainEntryPoint
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Math.Sum(7, 7));
            Console.ReadKey(true);
        }
    }
}
