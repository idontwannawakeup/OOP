using System;

namespace _15_DrawingTool
{
    class Square : Figure
    {
        public int Size { get; private set; }

        public override void Draw()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write('|');
                char value = (i == 0 || i == Size - 1) ? '-' : ' ';
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(value);
                }
                Console.WriteLine('|');
            }
        }

        public Square(int size)
        {
            Size = size;
        }
    }
}
