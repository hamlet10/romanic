using NUnit.Framework;
using romanic;


namespace romanic.test
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
            string result = Program.NumberToArabic(20);
            Assert.That("XX", Is.EqualTo(result));
        }

        [Test]
        public void Test2()
        {
            string result = Program.NumberToArabic(4);
            Assert.That("IV", Is.EqualTo(result));
        }
    }
}