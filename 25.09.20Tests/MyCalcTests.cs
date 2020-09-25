using MyCalcLib;
using NUnit.Framework;

namespace MyCalcLibTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_10_and_20_30returned()
        {
            //arrange(настройка)
            int x = 10;
            int y = 20;
            int expected = 30;
            //act(винолнение)
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);
            //assert(проверка)
            Assert.AreEqual(expected, actual);
        }
    }
}