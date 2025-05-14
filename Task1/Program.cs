namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();

        foreach (int item in array)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();

        var index = 0;
        while (index < array.Length) 
        {
            Console.Write($"{array[index]} ");
            index++;
        }

        Console.WriteLine();

        index = 0;
        do 
        {
            Console.Write($"{array[index]} ");
            index++;
        } while (index < array.Length);
    }
}
