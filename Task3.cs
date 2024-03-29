
class Task3
{
    public static void Main()
    {
        int n = 10;
        int[] array = new int[n];
        FillArray(array);
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Рекурсивная печать:");
        PrintRecursion(array, 0);
        Console.WriteLine();
    }

    private static void PrintRecursion(int[] array, int i)
    {
        if (i < array.Length - 1)
            PrintRecursion(array, i + 1);
        Console.Write($"{array[i]} ");
    }

    private static void FillArray(int[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(10, 100);
        }
    }
}