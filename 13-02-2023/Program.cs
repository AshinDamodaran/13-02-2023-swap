// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");  
  public class Example
{
    public static void Main(string[] args)
    {
        int x = 20, y = 30;
        Console.WriteLine("Before swap:");
        Console.WriteLine("x = " + x + " and y = " + y);
        x = x * y;
        y = x / y;
        x = x / y;
        Console.WriteLine("After swap:");
        Console.WriteLine("x = " + x + " and y = " + y);
    }
}