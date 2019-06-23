using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTest
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguements()
        {
//            Arrange
            var math = new Math();
//            Act
            var result = math.Add(1, 2);
//            Assert
            Assert.AreEqual(result, 3);
        }
        
        [Test]
        public void Max_FirstArguementIsGreater_ReturnFristArguement()
        {
//            Arrange
            var math = new Math();
//            Act
            var result = math.Max(2, 1);
//            Assert
            Assert.AreEqual(result, 2);
        }
        
        [Test]
        public void Max_SecondArguementIsGreater_ReturnSecondArguement()
        {
//            Arrange
            var math = new Math();
//            Act
            var result = math.Max(2, 3);
//            Assert
            Assert.AreEqual(result, 3);
        }
        
        [Test]
        public void Max_TwoItemHaveSameValue_ReturnSameItem()
        {
//            Arrange
            var math = new Math();
//            Act
            var result = math.Max(1, 1);
//            Assert
            Assert.AreEqual(result, 1);
        }
    }
}