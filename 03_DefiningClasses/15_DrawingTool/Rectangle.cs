using System;

namespace _15_DrawingTool
{
    class Rectangle : Figure
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.Write('|');
                char value = (i == 0 || i == Height - 1) ? '-' : ' ';
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(value);
                }
                Console.WriteLine('|');
            }
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
