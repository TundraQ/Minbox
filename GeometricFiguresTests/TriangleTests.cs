using GeometricFigures;
namespace GeometricFiguresTests
{
    [TestClass]
    public class TriangleTest
    {
        [ExpectedException(typeof(System.ArgumentOutOfRangeException), "Sides must be greater than 0\"")]
        [TestMethod]
        public void SideIsZero()
        {
            Triangle _ = new Triangle(0.0, 0.0, 0.0);
        }


        [ExpectedException(typeof(System.ArgumentOutOfRangeException), "Sides must be greater than 0\"")]
        [TestMethod]
        public void SideIsLessThanZero()
        {
            Triangle _ = new Triangle(-1.0, -1.0, -1.0);
        }

        [ExpectedException(typeof(System.ArgumentOutOfRangeException), "This triangle doesn't exist")]
        [TestMethod]
        public void TriangleNotExist()
        {
            Triangle _ = new Triangle(4.0, 5.0, 10.0);
        }


        [TestMethod]
        public void TriangleAreaDeltaCompute()
        {
            Triangle trg = new Triangle(5.0, 10.0, 8.0);
            Assert.AreEqual(19.81003533565753, trg.CalculateArea(), "Result out of range!");
        }


        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle trg = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(trg.IsRight());
        }


        [TestMethod]
        public void TriangleIsNotRight()
        {
            Triangle trg = new Triangle(10.0, 7.0, 11.0);
            Assert.IsFalse(trg.IsRight());
        }
    }
}
