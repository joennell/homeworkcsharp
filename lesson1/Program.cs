namespace lesson1;

public class Program
{
    public static void Main(string[] args)
    {
        var name = Console.ReadLine();
        SayHello(name);
    }

    public static void SayHello (string name)
    {
        Console.WriteLine(name + ", Hello!");
    }
}