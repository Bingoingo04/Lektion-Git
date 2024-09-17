namespace Lektion_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this super awesome game!");
            Console.WriteLine("Chose a nickname: ");
            string userNick = Console.ReadLine();
            Console.WriteLine($"Greetings, oh exalted {userNick}");
            Console.WriteLine("hello");

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("0-9 skrivs ut nu");
                }
                Console.WriteLine(i);
                
            }


        }
    }
}
