using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // methodName_seneriao_expectedBehavior
        public void CanBeCanceledBy_UserIsAdmin_ReturnTrue()
        {
//            Arrange
            var reservation = new Reservation();
//            Act
             var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});
//            Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceledBy_SameUser_ReturnTrue()
        { 
//            Arrange
            var user = new User();
            var reservation = new Reservation{MadeBy = user};
//            Act
            var result = reservation.CanBeCancelledBy(user);
//            Assert
            Assert.IsTrue(result);
        }
        
        [Test]
        public void CanBeCanceledBy_AnotherUser_ReturnFalse()
        { 
//            Arrange
            var reservation = new Reservation{MadeBy = new User()};
//            Act
            var result = reservation.CanBeCancelledBy(new User());
//            Assert
            Assert.IsFalse(result);
        }

    }
}