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
            Assert.AreEqual("BilgeAdam.TypeLogger.IMonster, BilgeAdam.TypeLogger.skeleton, skeleton, BilgeAdam.TypeLogger.EnemyMethods ", result);
        }

        [Test]
        public void TypeLogger_Test_Interface()
        {
            var result = Helper.TypeLogger<Zombie>();
            Assert.AreEqual("BilgeAdam.TypeLogger.IMonster, BilgeAdam.TypeLogger.Zombie, Zombie, System.Object ", result);
        }
    }
}