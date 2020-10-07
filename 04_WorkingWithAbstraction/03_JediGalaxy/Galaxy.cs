namespace _03_JediGalaxy
{
    class Galaxy
    {
        public int[,] Field { get; set; }
        public int Rows { get; }
        public int Cols { get; }

        public Galaxy(string[] dimensions)
            : this(int.Parse(dimensions[0]), int.Parse(dimensions[1])) { }

        public Galaxy(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;

            Field = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    Field[i, j] = (i * cols) + j;
        }
    }
}
