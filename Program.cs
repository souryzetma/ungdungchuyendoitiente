using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("usd: " );

        int usd = int.Parse(Console.ReadLine());

        Console.WriteLine("vnd: " + usd * 23000);
    }
}