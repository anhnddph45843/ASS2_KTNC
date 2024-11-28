
namespace TinhTich
{
    public class Tests
    {
        public int Tich(int a, int b)
        {
            return a * b;
        }
        [TestCase(1, 2, 2)]
        [TestCase(-10, 2, -20)]
        [TestCase(0, 5, 0)]
        [TestCase(10, -2, -20)]
        [TestCase(-10, -2, 20)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        [TestCase(1, int.MaxValue, int.MaxValue)]
        [TestCase(100, 1, 100)]
        [TestCase(100, -1, -100)]
        [TestCase(100, 0, -100)]
        public void Tinhtich(int a, int b, double kq)
        {
            int result = Tich(a , b);
            Assert.AreEqual(kq, result);
        }
    }
}
