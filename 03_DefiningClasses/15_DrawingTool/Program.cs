using System;

namespace _15_DrawingTool
{
    class Program
    {
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
