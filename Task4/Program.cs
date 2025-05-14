namespace Task4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Press W to move figure up\nPress S to move figure down\nPress A to move figure left\nPress D to move figure right\n");
        var command = Console.ReadLine().Trim().ToLower();

        switch (command) 
        {
            case "w":
                Console.WriteLine("Figure moved up");
                break;
            case "s":
                Console.WriteLine("Figure moved down");
                break;
            case "a":
                Console.WriteLine("Figure moved left");
                break;
            case "d":
                Console.WriteLine("Figure moved right");
                break;
            default:
                Console.WriteLine("Figure stayed at the same place");
                break;
        }
    }
}
