namespace GeometricFigures
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius must be greater than 0");
            _radius = radius;
        }

        public override double CalculateArea() => Math.PI * _radius * _radius;
    }
}
