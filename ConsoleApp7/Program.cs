namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }

        }
    }
}
