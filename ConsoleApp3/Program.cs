namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PrintTriangle(5);
        }
        static void PrintTriangle( int value)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }
        }
    }
}
