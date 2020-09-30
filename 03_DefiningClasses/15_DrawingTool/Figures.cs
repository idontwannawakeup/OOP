namespace _15_DrawingTool
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
}
