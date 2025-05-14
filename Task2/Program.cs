namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        for (int i = -99; i < 100; i++) 
        {
            if (i % 5 == 0 && Math.Abs(i) > 9) 
            {
                Console.Write(i + " ");
            }
        }
    }
}
