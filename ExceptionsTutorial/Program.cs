

using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Method1();
        } catch (Exception ex)
        {
            Console.WriteLine("Exception in Main");         
        }
    }
    private static void Method1()
    {
        Method2();
    }
    private static void Method2()
    {
        Method3();
     
    }
    private static void Method3()
    {
        int n = 0;
        int d = 0;
        int x = n / d;
        
    }
    private static void method4()
    {

    }
}
