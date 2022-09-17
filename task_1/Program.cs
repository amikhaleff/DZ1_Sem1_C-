internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("insert number a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("insert number b");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("maximum number a = " + a);
        }
else if (a < b)
        {
            Console.WriteLine("maximum number b = " + b);
        }
else
        {
            Console.WriteLine("number a - " + a + " = number b - " + b);
        }
    }
}