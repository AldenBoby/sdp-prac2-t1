using NUnit.Framework;
using Problems;

namespace Tests
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
            Program P = new Program();
            string Test1 = P.Prefix("hello");
            Assert.That(Test1, Is.EqualTo("5,1:hello"));
        }
        [Test]
        public void Test2()
        {
            Program P = new Program();
            string Test2 = P.Prefix("");
            Assert.That(Test2, Is.EqualTo("0,0:"));
        }
        [Test]
        public void Test3()
        {
            Program P = new Program();
            string Test3 = P.Prefix("what    ...  did you say?? ");
            Assert.That(Test3, Is.EqualTo("27,5:what    ...  did you say?? "));
        }
    }
}