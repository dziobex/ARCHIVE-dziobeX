using System;

namespace ascii_movie {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give a path to the file: ");
            string path = Console.ReadLine();
            Movie movie = new Movie(path);
        }
    }
}
