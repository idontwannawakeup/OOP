namespace _03_Shapes.Models
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public virtual string Draw()
            => "It's a shape, trust me.";
    }
}
