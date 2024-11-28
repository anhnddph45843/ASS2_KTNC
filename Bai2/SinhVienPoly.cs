using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class SinhVienPoly
    {
        private List<SinhVien> Poly = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sv)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(sv.Tenlop, "^[a-zA-Z0-9 ]+$"))
            {
                throw new ArgumentException("Tên lớp chứa ký tự đặc biệt.");
            }
            Poly.Add(sv);
        }
        public List<SinhVien> TimTheoMaSV(string masv)
        {
            return Poly.Where(sv => sv.Masv == masv).ToList();
        }
    }
}
