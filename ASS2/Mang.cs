using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2
{
    internal class Mang
    {
        public object TruyXuat(object[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "mang khong duoc null");

            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("index ngoai mang");

            return array[index];
        }
        private Mang _truyXuat;

        [SetUp]
        public void Setup()
        {
            _truyXuat = new Mang();
        }
        [Test]
        public void GetElementAtIndex_ValidIndex_ReturnsCorrectElement()
        {
            var array = new object[] { "A", "B", "C", "D" };
            var result = _truyXuat.TruyXuat(array, 2);
            Assert.AreEqual("C", result);
        }
        [Test]
        public void GetElementAtIndex_NegativeIndex_ThrowsIndexOutOfRangeException()
        {
            var array = new object[] { "A", "B", "C", "D" };
            Assert.Throws<IndexOutOfRangeException>(() => _truyXuat.TruyXuat(array, -1));
        }
        [Test]
        public void GetElementAtIndex_IndexOutOfRange_ThrowsIndexOutOfRangeException()
        {
            var array = new object[] { "A", "B", "C", "D" };
            Assert.Throws<IndexOutOfRangeException>(() => _truyXuat.TruyXuat(array, 4));
        }
    }
}
