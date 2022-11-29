using Application;

namespace CI_CD
{
    public class Tests
    {
        private MyClass myClass;

        [SetUp]
        public void Setup() {
            myClass = new MyClass();
        }

        [Test]
        public void MyFunc() {
            Assert.AreEqual(true, myClass.MyFunc(true));
        }
    }
}