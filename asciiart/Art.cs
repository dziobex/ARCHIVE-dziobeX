using System;
using System.Drawing;
using System.IO;

namespace asciiart {
    public class Art {
        const int SIZE = 5;

        Bitmap bmp;
        Bitmap canvas;
        Random rnd;

        public Art(string path) {
            rnd = new Random();

            try {
                bmp = new Bitmap(path);
                bmp = new Bitmap(bmp, bmp.Width / SIZE, bmp.Height / SIZE);

                canvas = new Bitmap(1, 1);
                canvas.SetPixel(0, 0, Color.Black);
                canvas = new Bitmap(canvas, bmp.Width * (SIZE + 1), bmp.Height * (SIZE + 1));

                drawImage();
            } catch {
                Console.WriteLine($"Couldn't find your file, but don't feel blue and hold TUX.");
                bmp = new Bitmap("tux.jpg");

                for (int y = 0; y < bmp.Height; y++) {
                    for (int x = 0; x < bmp.Width; x++) {
                        var pixel = bmp.GetPixel(x, y);
                        Console.ForegroundColor = getColor(pixel);
                        Console.Write($"{getChar(pixel.GetBrightness(), true)} ");
                    }
                    Console.WriteLine("");
                }
            }
        }

        void drawImage() {
            using (var g = Graphics.FromImage(canvas)) {
                for (int y = 0; y < bmp.Height; ++y)
                    for (int x = 0; x < bmp.Width; ++x) {
                        var pixel = bmp.GetPixel(x, y);
                        g.DrawString($"{getChar(pixel.GetBrightness(), false)}", new Font("Arial", SIZE), new SolidBrush(pixel), x + (x * SIZE), y + (y * SIZE));
                    }
            }
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", filename = "";
            for (int i = 0; i < 10; ++i)
                filename += characters[rnd.Next(characters.Length)];

            if (!Directory.Exists("Images"))
                Directory.CreateDirectory("Images");

            canvas.Save($@"Images\{filename}.jpg");
            Console.WriteLine("Done. Path to your ASCII-img:\n" + $@"{System.Reflection.Assembly.GetEntryAssembly().Location}\Images\{filename}.jpg");
            Console.ReadKey();
        }

        char getChar(double brightness, bool tux) {
            switch (brightness) {
                case double n when (brightness == 0):
                    if (tux) return ' ';
                    return 'D';
                case double n when (brightness <= 0.1):
                    if (tux) return '#';
                    return 'W';
                case double n when (brightness <= 0.2):
                    if (tux) return '#';
                    return 'P';
                case double n when (brightness <= 0.4):
                    if (tux) return '&';
                    return 'A';
                case double n when (brightness <= 0.5):
                    if (tux) return '%';
                    return 'F';
                case double n when (brightness <= 0.6):
                    if (tux) return '*';
                    return 'd';
                case double n when (brightness <= 0.7):
                    if (tux) return '^';
                    return 'g';
                case double n when (brightness <= 0.8):
                    if (tux) return '^';
                    return 'q';
                default:
                    if (tux) return (char)39;
                    return 'o';
            }
        }

        ConsoleColor getColor(Color pixel)
            => (ConsoleColor)(((pixel.R > 128 || pixel.G > 128 || pixel.B > 128) ? 8 : 0) | ((pixel.R > 64) ? 4 : 0) | ((pixel.G > 64) ? 2 : 0) | ((pixel.B > 64) ? 1 : 0));
    }
}
