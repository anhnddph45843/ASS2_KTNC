
namespace TinhHieu
{
    public class Hieu
    {
        public int hieu(int a, int b)
        {
            return a - b;
        }
        [TestCase(1, 2, -1)]
        [TestCase(-10, 2, -12)]
        [TestCase(0, 5, -5)]
        [TestCase(10, -2, 12)]
        [TestCase(-10, -2, -8)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, -1)]
        [TestCase(1, int.MaxValue, -int.MaxValue)]
        [TestCase(100, 1, 99)]
        [TestCase(100, -1, 101)]
        [TestCase(100, 0, -100)]
        public void TinhHieu(int a, int b, double kq)
        {
            int result = hieu(a, b);
            Assert.AreEqual(kq, result);
        }
    }
}
