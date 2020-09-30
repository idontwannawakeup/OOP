using System;

namespace _15_DrawingTool
{
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
}
