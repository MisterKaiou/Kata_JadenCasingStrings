using NUnit.Framework;
using Jaden.CasingStrings;

namespace Jaden.CasingStrings.Tests
{
    public class JadenCasingTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                            "Strings didn't match.");
        }
    }
}