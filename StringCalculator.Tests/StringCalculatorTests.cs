using NUnit.Framework;

namespace StringCalculator.Tests {
    /// <summary>
    /// Clase de Tests unitarios de <seealso cref="StringCalculator"/>
    /// </summary>
    [TestFixture]
    public class StringCalculatorTests {
        
        [Test]
        public void Add_EmptyString_ReturnsZero() {
            var result = Kata._12082013.StringCalculator.Add(string.Empty);
            Assert.AreEqual(0, result);
        }

        [Test]
        [TestCase("4,4", 8)]
        public void Add_ManyNumbersString_ReturnsAddition(string numbers, int expected) {
            var result = Kata._12082013.StringCalculator.Add(numbers);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("2", 2)]
        [TestCase("15", 15)]
        public void Add_OneNumberString_ReturnsZero(string number, int expected) {
            var result = Kata._12082013.StringCalculator.Add(number);
            Assert.AreEqual(expected, result);
        }
    }
}
