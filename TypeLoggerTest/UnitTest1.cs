using BilgeAdam.TypeLogger;
using NUnit.Framework;

namespace TypeLoggerTest
{
    [TestFixture]
    public class TypeLoggerTestFixture
    {
        
        [Test]
        public void TypeLogger_test_Abstract_and_interface()
        {
            var result = Helper.TypeLogger<skeleton>();
        }

        [Test]
        public void TypeLogger_Test_Interface()
        {
            var result = Helper.TypeLogger<>
        }
    }
}