namespace GeometricFigures
{
    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <=  0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentOutOfRangeException("Sides must be greater than 0");
            if (!(side1 < side2+side3 && side2 < side1+side3 && side3 < side1+side2))
                throw new ArgumentOutOfRangeException("This triangle doesn't exist");

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public bool IsRight()
        {
            double[] sides = { side1, side2, side3};
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= 0.00001;
        }

        public override double CalculateArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }
}
