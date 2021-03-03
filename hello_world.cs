using System;

// UN CORDIALE SALUTO
namespace _20210303
{
    class hello_world
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("Hello World!");
            }
            else {
                string name = args[0];
                Console.WriteLine("Hello, " + name);
                }
            
        }
    }
}
