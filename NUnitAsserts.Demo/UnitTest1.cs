using NUnit.Framework;

namespace NUnitAsserts.Demo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Multiple(() =>
            {
                // some code
                // ....
                //
                Assert.AreEqual(1, 0, "Verify equals");

                // some code
                // ....
                //
                Assert.IsTrue(false, "Verify true");
            });

            Assert.That(0, Is.Zero, "Verify Is.Zero");
            Assert.That("Hello", Does.StartWith("H"));
        }
    }
}