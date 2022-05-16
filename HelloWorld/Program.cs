using System;

namespace HelloWorld
{
   class HelloWorld
   {
        static void Main(String[] args)
        {
            Console.Write("Hey, what is your name ?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello there !" +name);
        }
   }
}
