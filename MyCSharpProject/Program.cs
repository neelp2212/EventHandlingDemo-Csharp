using System;

class Program
{
    static void Main(string[] args)
    {
        int age = 23;
        Console.WriteLine(age);

        long num = 1000000L;
        System.Console.WriteLine(num);

        double negative = -55.2D;
        System.Console.WriteLine(negative);

        float precision = 11.000022F;
        System.Console.WriteLine(precision);

        decimal money = 14.99M;
        System.Console.WriteLine(money);

        System.Console.WriteLine(int.MaxValue);
        System.Console.WriteLine(long.MaxValue);
        System.Console.WriteLine(double.MaxValue);
        System.Console.WriteLine(float.MaxValue);
    }
}
