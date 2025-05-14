namespace Task3;

internal class Program
{
    static void Main(string[] args)
    {
        var num = -20;

        do 
        { 
            Console.WriteLine(num);
            num -= 20; 
        } while (num >= -100);
    }
}
