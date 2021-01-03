using System;

namespace asciiart {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Give the path to the file:");
            string path = Console.ReadLine();

            Art art = new Art(path);
        }
    }
}
