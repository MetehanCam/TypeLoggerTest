using BilgeAdam.TypeLogger;
using NUnit.Framework;

namespace TypeLoggerTest
{
    [TestFixture]
    public class TypeLoggerTestFixture
    {

       

        [Test]
        public void TypeLogger_Test_Interface()
        {
            var result = Helper.TypeLogger<IMonster>();
            Assert.AreEqual("BilgeAdam.TypeLogger.IMonster, IMonster,  AbstractInterface", result);
        }

        [Test]
        public void TypeLogger_Test_Abstract()
        {
            var result = Helper.TypeLogger<EnemyMethods>();
            Assert.AreEqual("BilgeAdam.TypeLogger.EnemyMethods, EnemyMethods, System.Object AbstractClass", result);
        }

        [Test]
        public void TypeLogger_test_Class_With_interface()
        {
            var result = Helper.TypeLogger<Zombie>();
            Assert.AreEqual("BilgeAdam.TypeLogger.IMonster, BilgeAdam.TypeLogger.Zombie, Zombie, System.Object Class", result);
        }

        [Test]
        public void TypeLogger_test_Class_With_Abstract_and_interface()
        {
            var result = Helper.TypeLogger<skeleton>();
            Assert.AreEqual("BilgeAdam.TypeLogger.IMonster, BilgeAdam.TypeLogger.skeleton, skeleton, BilgeAdam.TypeLogger.EnemyMethods Class", result);
        }
    }
}