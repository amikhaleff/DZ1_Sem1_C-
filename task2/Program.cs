Console.WriteLine("insert number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("insert number b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("insert number c");
int c = int.Parse(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine("maximum number a = " + a);
}
else if (b > c)
{
    Console.WriteLine("maximum number b = " + b);
}
else if (c > b)
{
    Console.WriteLine("maximum number c = " + c);
}
else
{
    Console.WriteLine("number a - " + a + " = number b - " + b + " = number c - " + c);
}