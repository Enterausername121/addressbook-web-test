using NUnit.Framework;

namespace addressbook_web_test
{
    public class Tests
    {
        [Test]
        public void TestMethodSquare()
        {
            square s1 = new square(5);
            square s2 = new square(10);
            square s3 = s1;

            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = (15);

            Assert.AreEqual(s3.Size, 15);

            s2.Colored = true;

        }

        [Test]
        public void TestMethodCircle()
        {
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Radius, 5);
            Assert.AreEqual(s2.Radius, 10);
            Assert.AreEqual(s3.Radius, 5);

            s3.Radius = (15);

            Assert.AreEqual(s3.Radius, 15);

            s2.Colored = true;
        }

    }
}