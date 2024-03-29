
class Task2
{
    public static void Main(string[] args)
    {
        int m;
        int n;
        if (!CheckParams(args, out m, out n)) return;
        Console.WriteLine(Akkerman(m, n));
    }

    private static int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
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
        }
        else
        {
            Console.WriteLine("Неверные данные: Необходимы два натуральных числа.");
            return false;
        }
        return true;
    }

}