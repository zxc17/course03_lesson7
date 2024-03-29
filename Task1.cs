
class Task1
{
    public static void Main(string[] args)
    {
        int m;
        int n;
        if (!CheckParams(args, out m, out n)) return;
        PrintDigit(m, n);
    }

    private static void PrintDigit(int m, int n)
    {
        Console.WriteLine(m);
        if (m < n)
            PrintDigit(m + 1, n);
    }

    private static bool CheckParams(string[] args, out int m, out int n)
    {
        n = 0;
        m = 0;
        if (int.TryParse(args[0], out m) && int.TryParse(args[1], out n))
        {
            if (m < 1 || n < 1)
            {
                Console.WriteLine("Неверные данные: Числа должны быть натуральными.");
                return false;
            }
            if (m > n)
            {
                Console.WriteLine("Неверные данные: Второй параметр не может быть меньше первого.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Неверные данные: Необходимы два натуральных числа.");
            return false;
        }
        return true;
    }
}