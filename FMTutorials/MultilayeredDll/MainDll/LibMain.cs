namespace FMTutorials.MultilayeredDll.MainDll
{
    using Log = FMTutorials.MultilayeredDll.DependencyDll.LibDependency;
    
    public static class LibMain
    {
        public static int Sum(int a, int b)
        {
            Log.Info("Entering sum");
            Log.Info("Getting sum of {0} and {1}...", a, b);
            return a + b;
        }
    }
}
