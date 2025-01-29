namespace ConsoleApp2
{/// <summary>
/// Задание 1 часть а
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTable();
            Console.ReadKey();
        }
        static void PrintTable()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
