using System;

namespace _15_DrawingTool
{
    class DrawingTool
    {
        private Figure figureToDraw;

        public void Draw()
        {
            figureToDraw.Draw();
        }

        public DrawingTool(Figure figure)
        {
            figureToDraw = figure;
        }
    }
}
