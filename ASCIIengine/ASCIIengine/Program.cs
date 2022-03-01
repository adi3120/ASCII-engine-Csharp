using System;

namespace ASCIIengine
{
    class Program
    {
        static int w = 10, h = 10;
        static char[,] canvas = new char[w, h];


        static void Main(string[] args)
        {

            int i = 0;
            while (true)
            {
                fillCanvas();
                plot(5, i);
                draw_rectangle(0, 0, 5, 5);
                show();
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                if (i < w - 2)
                    i++;

            }

        }
        static void fillCanvas()
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    canvas[i, j] = '.';
                }
            }
        }
        static void show()
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(canvas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void plot(int x, int y, char pixel = '#')
        {
            canvas[y, x] = pixel;
        }

        static void draw_rectangle(int x, int y, int w, int h, char pixel = '#')
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (x + i == 0 || y + j == 0 || x + i == w - 1 || y + j == h - 1)
                        plot(x + i, y + j);
                }
            }
        }



    }
}
