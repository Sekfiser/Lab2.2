using Lab1._2;
using NUnit.Framework;

namespace Lab1._4.Tests
{
    public class Tests
    {
        private InputedArgs input;
        [SetUp]
        public void Setup()
        {
            string[] args = new string[] { "1", "2", "3", "4", "5", "7", "8", "9", "0" };

            input = new InputedArgs(args);
        }

        [Test]
        public void Input_form_1_to_0_sum_result39()
        {
            int result = input.Sum();
            Assert.AreEqual(39, result);
        }

        [Test]
        public void Input_form_1_to_0_mul_result0()
        {
            int result = input.Multi();
            Assert.AreEqual(0, result);
        }

        [TestCase(new string[] { "5", "5", "test" }, 10)]
        [TestCase(new string[] { "asd", "asd", "asd" }, 0)]
        [TestCase(new string[] { "5", "5", "5" }, 15)]
        public void Strings_in_input_sum(string[]input, int sum)
        {
            int result = new InputedArgs(input).Sum();
            Assert.AreEqual(sum, result);
        }

        [TestCase(new string[] { "5", "5", "test" }, 25)]
        [TestCase(new string[] { "asd", "asd", "asd" }, 1)]
        [TestCase(new string[] { "5", "5", "5" }, 125)]
        [TestCase(new string[] { "5", "5", "0" }, 0)]
        public void Strings_in_input_mul(string[] input, int mul)
        {
            int result = new InputedArgs(input).Multi();
            Assert.AreEqual(mul, result);
        }
    }
}