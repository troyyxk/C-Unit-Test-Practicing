using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Fundamentals;


//    
namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTest
    {
        private Math _math;

//        SetUp
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
//        TearDown

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguements()
        {
//            Arrange
//            Act
            var result = _math.Add(1, 2);
//            Assert
            Assert.AreEqual(result, 3);
        }

         [Test]
         [TestCase(2, 1, 2)]
         [TestCase(2, 3, 3)]
         [TestCase(1, 1, 1)]
         public void Max_WhenCalled_ReturnMTheGreaterArguement(int a, int b, int expected)
        {
//            Arrange
//            Act
            var result = _math.Max(a, b);
//            Assert
            Assert.AreEqual(result, expected);
        }

         [Test]
         public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
         {
//            Arrange
//            Act
             var result = _math.GetOddNumbers(5);
//            Assert
             Assert.That(result, Is.Not.Empty);
             Assert.That(result.Count(), Is.EqualTo((3)));
             Assert.That(result, Does.Contain((1)));
             Assert.That(result, Does.Contain((3)));
             Assert.That(result, Does.Contain((5)));
             
             Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));
         }
    }
}


//    [Test]
//    public void Max_FirstArguementIsGreater_ReturnFristArguement()
//    {
////            Arrange
////            Act
//    var result = _math.Max(2, 1);
////            Assert
//    Assert.AreEqual(result, 2);
//    }
//        
//    [Test]
//    public void Max_SecondArguementIsGreater_ReturnSecondArguement()
//    {
////            Arrange
////            Act
//    var result = _math.Max(2, 3);
////            Assert
//    Assert.AreEqual(result, 3);
//    }
//        
//    [Test]
//    public void Max_TwoItemHaveSameValue_ReturnSameItem()
//    {
////            Arrange
////            Act
//    var result = _math.Max(1, 1);
////            Assert
//    Assert.AreEqual(result, 1);
//    }
    
////    The old ones for the tests before set up and tear down.
//    [Test]
//    public void Add_WhenCalled_ReturnTheSumOfArguements()
//    {
////            Arrange
//    var math = new Math();
////            Act
//    var result = math.Add(1, 2);
////            Assert
//    Assert.AreEqual(result, 3);
//    }
//        
//    [Test]
//    public void Max_FirstArguementIsGreater_ReturnFristArguement()
//    {
////            Arrange
//    var math = new Math();
////            Act
//    var result = math.Max(2, 1);
////            Assert
//    Assert.AreEqual(result, 2);
//    }
//        
//    [Test]
//    public void Max_SecondArguementIsGreater_ReturnSecondArguement()
//    {
////            Arrange
//    var math = new Math();
////            Act
//    var result = math.Max(2, 3);
////            Assert
//    Assert.AreEqual(result, 3);
//    }
//        
//    [Test]
//    public void Max_TwoItemHaveSameValue_ReturnSameItem()
//    {
////            Arrange
//    var math = new Math();
////            Act
//    var result = math.Max(1, 1);
////            Assert
//    Assert.AreEqual(result, 1);
//    }
//}
