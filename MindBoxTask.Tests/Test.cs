using System;
using MindBoxTask.Shapes;
using NUnit.Framework;
namespace MindBoxTask.Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TriangleShouldBeRightAngled()
        {
            var shape = new Triangle(3, 4, 5);
            Assert.IsTrue(shape.IsRightAngled());
        }

        [Test()]
        public void TriangleShouldNotBeRightAngled()
        {
            var shape = new Triangle(3, 4, 6);
            Assert.IsFalse(shape.IsRightAngled());
        }

        [Test()]
        public void TriangleAreaShouldBeCorrect()
        {
            var shape = new Triangle(3, 4, 5);
            Assert.AreEqual(shape.CalculateArea(), 6);
        }

        [Test()]
        public void CircleAreaShouldBeCorrect()
        {
            var shape = new Circle(3);
            Assert.AreEqual(Math.Round(shape.CalculateArea(), 2), 28.27);
        }
    }
}
