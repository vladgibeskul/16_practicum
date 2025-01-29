namespace ConsoleApp1
{
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
                int currentValue = 41 + i * 10;
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{currentValue + j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
