using NUnit.Framework;
using System.Linq;

namespace Bai2
{

      [TestFixture]
      public class SinhVienPolyTests
        {
            private SinhVienPoly Testpoly;

            [SetUp]
            public void Setup()
            {
                Testpoly = new SinhVienPoly();
            }
            [Test]
            public void ThemSinhVien_TenLopTrong()
            {
                var sinhVien = new SinhVien("ph1", "Nguyen Van A", "Sd1", "", "SV001");
                Assert.Throws<Exception>(() => Testpoly.ThemSinhVien(sinhVien));
            }
            [Test]
            public void ThemSinhVien_TenLopCoKyTuDacBiet()
            {
            var sinhVien = new SinhVien("1", "Nguyen Van A", "K1", "Khoa CNTT@", "SV001");
            Assert.Throws<ArgumentException>(() => Testpoly.ThemSinhVien(sinhVien));
            }
            [Test]
            public void ThemSinhVien_Tatcabotrong()
            {
                var sinhVien = new SinhVien("", "", "", "", "");
                Assert.Throws<ArgumentNullException>(() => Testpoly.ThemSinhVien(sinhVien));
            }
            [Test]
             public void ThemSinhVien_BotrongID()
             {
                var sinhVien = new SinhVien("", "Nguyen Van A", "K1", "Khoa CNTT", "SV001");
                Assert.Throws<ArgumentException>(() => Testpoly.ThemSinhVien(sinhVien));
             }
            [Test]
            public void ThemSinhVien_BotrongTen()
            {
                var sinhVien = new SinhVien("1", "", "K1", "Khoa CNTT", "SV001");
                Assert.Throws<ArgumentException>(() => Testpoly.ThemSinhVien(sinhVien));
            }
            [Test]
            public void ThemSinhVien_BotrongMalop()
            {
                var sinhVien = new SinhVien("1", "FA2", "", "Khoa CNTT", "SV001");
                Assert.Throws<ArgumentException>(() => Testpoly.ThemSinhVien(sinhVien));
            }
            [Test]
            public void ThemSinhVien_BotrongMasv()
            {
                var sinhVien = new SinhVien("1", "Sg431", "K1", "Khoa CNTT", "");
                Assert.Throws<ArgumentException>(() => Testpoly.ThemSinhVien(sinhVien));
            }
        [Test]
            public void TimTheoMasv_MaSvHopLe_TimThay()
            {
                var sinhVien = new SinhVien("1", "Nguyen Van A", "K1", "Khoa CNTT", "SV001");
                Testpoly.ThemSinhVien(sinhVien);
                var ketQua = Testpoly.TimTheoMaSV("SV001");
                Assert.AreEqual(1, ketQua.Count);
            }
        [Test]
        public void TimTheoMasv_MaSvKhongTonTai_TraVeDanhSachRong()
        {
           
            var sinhVienPoly = new SinhVienPoly();
            var maSvKhongTonTai = "SV005";
            var ketQua = sinhVienPoly.TimTheoMaSV(maSvKhongTonTai);
            Assert.IsEmpty(ketQua); 
        }
        [Test]
        public void TimTheoMasv_DanhSachRong_TraVeDanhSachRong()
        {
            var sinhVienPoly = new SinhVienPoly();
            var maSvBatKy = "SV001";
            var ketQua = sinhVienPoly.TimTheoMaSV(maSvBatKy);
            Assert.IsEmpty(ketQua);
        }
        [Test]
        public void TimTheoMasv_MaSvNull_NgoaiLe()
        {
            var sinhVienPoly = new SinhVienPoly();
            string maSvNull = null;
            Assert.Throws<ArgumentNullException>(() => sinhVienPoly.TimTheoMaSV(maSvNull));
        }
        [Test]
        public void TimTheoMasv_MaSvRong_NgoaiLe()
        {
            var sinhVienPoly = new SinhVienPoly();
            string maSvRong = "";
            Assert.Throws<ArgumentException>(() => sinhVienPoly.TimTheoMaSV(maSvRong));
        }
    }
}