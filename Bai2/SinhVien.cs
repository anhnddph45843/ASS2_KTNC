public class SinhVien
{
    public string Id { get; set; }
    public string Hoten { get; set; }
    public string Malop { get; set; }
    public string Tenlop { get; set; }
    public string Masv { get; set; }

    // Constructor
    public SinhVien(string id, string hoten, string malop, string tenlop, string masv)
    {
        Id = id;
        Hoten = hoten;
        Malop = malop;
        Tenlop = tenlop;
        Masv = masv;
    }
}
