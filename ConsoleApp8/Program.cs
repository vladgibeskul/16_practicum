namespace ConsoleApp8
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
            for (int i = 0; i < 4; i++)
            {
                
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("# "); 
                }
                Console.WriteLine(); 
            }
        }
    }
}
