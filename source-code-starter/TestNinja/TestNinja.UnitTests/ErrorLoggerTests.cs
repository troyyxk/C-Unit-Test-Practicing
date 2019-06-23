using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
//            Arrange
            var logger = new ErrorLogger();
//            Act
            logger.Log("a");
//            Assert
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArguementNullException(string error)
        {
//            Arrange
            var logger = new ErrorLogger();
//            Act
//            Assert
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }
        
    }
}