using GeometricFigures;

namespace GeometricFiguresTests
{
    [TestClass]
    public class CircleTest
    {

        [ExpectedException(typeof(System.ArgumentOutOfRangeException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle _ = new Circle(0.0);
        }

        [ExpectedException(typeof(System.ArgumentOutOfRangeException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle _ = new Circle(-1.0);
        }


        [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle crc = new Circle(2.0);
            Assert.AreEqual(12.566370614359172, crc.CalculateArea(),  "Result out of range!");
        }
    }
}