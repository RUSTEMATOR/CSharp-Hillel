namespace HMW11._1;

public static class FibonacciHelper
{
    public static int Calculate(int n)
    {                                                                                                                                                                                                                                      
        if (n == 1) return 0;               
        if (n == 2) return 1;                                                                                                                                                                                     
                                                                                                                                                                                                                                         
        return Calculate(n - 1) + Calculate(n - 2);                                                                                                                                                                     
    } 
}
