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
        [Test]
        public void SingleTestmanyitems()//Question 20
        {
            Program P = new Program();
            string Test1 = P.Prefix("hello");
            Assert.That(Test1, Is.EqualTo("5,1:hello"));

            string Test2 = P.Prefix("");
            Assert.That(Test2, Is.EqualTo("0,0:"));

            string Test3 = P.Prefix("what    ...  did you say?? ");
            Assert.That(Test3, Is.EqualTo("27,5:what    ...  did you say?? "));

            string Test4 = P.Prefix("Why does my travis build keep failing");
            Assert.That(Test4, Is.EqualTo("37,7:Why does my travis build keep failing"));

            string Test5 = P.Prefix("It works on my cmd");
            Assert.That(Test5, Is.EqualTo("18,5:It works on my cmd"));

            string Test6 = P.Prefix("But travis    cant find the namespace  Nunit");
            Assert.That(Test6, Is.EqualTo("44,7:But travis    cant find the namespace  Nunit"));
        }
    }
}