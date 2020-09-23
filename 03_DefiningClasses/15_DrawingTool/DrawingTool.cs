using System;

namespace _15_DrawingTool
{
    class Program
    {
        class Figure
        {
            public int Width { get; protected set; }
            public int Height { get; protected set; }
        }

        class Rectangle : Figure
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        class Square : Figure
        {
            public Square(int size)
            {
                Width = Height = size;
            }
        }

        class DrawingTool
        {
            private Figure figureToDraw;

            public void Draw()
            {
                for (int i = 0; i < figureToDraw.Height; i++)
                {
                    Console.Write('|');
                    char value = (i == 0 || i == figureToDraw.Height - 1) ? '-' : ' ';
                    for (int j = 0; j < figureToDraw.Width; j++)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine('|');
                }
            }

            public DrawingTool(Figure figure)
            {
                figureToDraw = figure;
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            Figure figureToDraw;
            if (type.Equals("Square"))
            {
                int size = int.Parse(Console.ReadLine());
                figureToDraw = new Square(size);
            }
            else
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                figureToDraw = new Rectangle(width, height);
            }

            DrawingTool dt = new DrawingTool(figureToDraw);
            dt.Draw();

            Console.ReadKey();
        }
    }
}
