using System;

namespace Classes_Cook_Jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            greetings greetings = new greetings();
            greetings.Welcome();

            Console.Writeline("What is your name squire?");
            string userName = Console.Readline()
            greetings.Hello(userName);
        }
    }
}
