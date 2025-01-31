namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
            Console.ReadKey();
            
        }
        static void PrintTriangle()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" 1");
                }
                Console.WriteLine();
            }

        }
    }
}
