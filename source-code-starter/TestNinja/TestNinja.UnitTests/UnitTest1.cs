using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Tests
{
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // methodName_seneriao_expectedBehavior
        public void CanBeCanceledBy_UseIsAdmin_ReturnTrue()
        {
//            Arrange
            var reservation = new Reservation();
//            Act
             var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});
//            Assert
            Assert.IsTrue(result);
        }
    }
}