using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2
{
    internal class TinhTrungBinh
    {
        public double? TinhTrungBinh1(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return null;
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }
        private TinhTrungBinh _tinhTrungBinh;

        [SetUp]
        public void Setup()
        {
            _tinhTrungBinh = new TinhTrungBinh();
        }
        [Test]
        public void Test1()
        {
            var numbers = new List<double> { 10, 20, 30, 40, 50 };
            var result = _tinhTrungBinh.TinhTrungBinh1(numbers);
            Assert.AreEqual(30, result);
        }


        [Test]
        public void Test2()
        {
            var numbers = new List<double>();
            var result = _tinhTrungBinh.TinhTrungBinh1(numbers);
            Assert.IsNull(result);
        }


        [Test]
        public void Test3()
        {
            var result = _tinhTrungBinh.TinhTrungBinh1(null);
            Assert.IsNull(result);
        }

    }
}
