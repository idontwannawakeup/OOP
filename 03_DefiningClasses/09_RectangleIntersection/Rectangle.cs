namespace _09_RectangleIntersection
{
    struct Coordinates
    {
        public int x;
        public int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Rectangle
    {
        private Coordinates leftTopCorner;

        public string Id { get; }
        public int Width { get; }
        public int Height { get; }
        public Coordinates LeftTopCorner { get => leftTopCorner; }

        public Coordinates CalculateRightBottomCorner()
        {
            return new Coordinates(leftTopCorner.x + Width, leftTopCorner.y - Height);
        }

        public Rectangle(string id, int width, int height, int x, int y)
        {
            Id = id;
            Width = width;
            Height = height;
            leftTopCorner = new Coordinates(x, y);
        }

        public bool CheckIntersection(Rectangle other)
        {
            var thisLeftTop = LeftTopCorner;
            var thisRightBottom = CalculateRightBottomCorner();
            var otherLeftTop = other.LeftTopCorner;
            var otherRightBottom = other.CalculateRightBottomCorner();

            // otherRightBottom should be between thisLeftTop and thisRightBottom
            // or otherLeftTop should be between thisLeftTop and thisRightBottom
            return (otherRightBottom.x <= thisRightBottom.x && otherRightBottom.y >= thisRightBottom.y &&
                    otherRightBottom.x >= thisLeftTop.x && otherRightBottom.y <= thisLeftTop.y) ||
                   (otherLeftTop.x <= thisRightBottom.x && otherLeftTop.y >= thisRightBottom.y &&
                    otherLeftTop.x >= thisLeftTop.x && otherLeftTop.y <= thisLeftTop.x);
        }
    }
}
