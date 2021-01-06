using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace ascii_movie {
    public class Movie {
        Random rnd;
        const int SIZE = 10;
        const int FRAMES = 5;

        public Movie(string path) {
            rnd = new Random();
            if (!File.Exists(path)) {
                Console.WriteLine("Couldn't find the file :[");
                return;
            } else if (path.Substring(path.Length-3, 3) != "mov" && path.Substring(path.Length - 3, 3) != "mp4" && path.Substring(path.Length - 3, 3) != "mp3" && path.Substring(path.Length - 3, 3) != "avi") {
                Console.WriteLine("Invalid format. Availabe formats: mov, mp4, mp3, avi.");
                return;
            }

            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", filename = "";
            for (int i = 0; i < 10; ++i)
                filename += characters[rnd.Next(characters.Length)];

            generateVideo(path, filename);
            Console.WriteLine("Done. Find your file:\n" + $@"{System.Reflection.Assembly.GetEntryAssembly().Location}\{filename}.mp4");
        }

        void generateVideo(string path, string filename) {
            int i = -1;
            var fcc = VideoWriter.Fourcc('m', 'p', '4', 'v');

            Stopwatch watch = new Stopwatch();
            watch.Start();
            using (var video = new VideoCapture(path))
            using (var writer = new VideoWriter(@$"{filename}.mp4", fcc, video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps) / FRAMES,
                new Size((int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth), (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight)), true))
            using (var img = new Mat()) {
                while (video.Grab()) {
                    if (++i % FRAMES == 0) {
                        video.Read(img);
                        Bitmap bmp = new Bitmap (convertIntoAscii(img.ToBitmap()), (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth), (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
                        Image<Bgr, byte> frame = bmp.ToImage<Bgr, byte>();
                        writer.Write(frame.Mat);
                    }
                }
            }
            watch.Stop();
            Console.WriteLine($"\u001b[36mTime: {watch.ElapsedMilliseconds/60} sec.\u001b[0m");
        }

        Bitmap convertIntoAscii(Bitmap bmp) {
            bmp = new Bitmap(bmp, bmp.Width / SIZE, bmp.Height / SIZE);

            Bitmap canvas = new Bitmap(1, 1);
            canvas.SetPixel(0, 0, Color.Black);
            canvas = new Bitmap(canvas, bmp.Width * (SIZE + 1), bmp.Height * (SIZE + 1));
            using (var g = Graphics.FromImage(canvas)) {
                for (int y = 0; y < bmp.Height; ++y)
                    for (int x = 0; x < bmp.Width; ++x) {
                        var pixel = bmp.GetPixel(x, y);
                        g.DrawString($"{getChar(pixel.GetBrightness())}", new Font("Arial", SIZE), new SolidBrush(pixel), x + (x * SIZE), y + (y * SIZE));
                    }
            }
            return canvas;
        }

        char getChar(double brightness) {
            switch (brightness) {
                case double n when (brightness == 0):
                    return '#';
                case double n when (brightness <= 0.1):
                    return '@';
                case double n when (brightness <= 0.2):
                    return '%';
                case double n when (brightness <= 0.4):
                    return '$';
                case double n when (brightness <= 0.5):
                    return '^';
                case double n when (brightness <= 0.6):
                    return '*';
                case double n when (brightness <= 0.7):
                    return '(';
                case double n when (brightness <= 0.8):
                    return ')';
                default:
                    return 'o';
            }
        }
    }
}
