namespace GozetmenTakipSistemi.Models
{
    internal class Exam
    {
        public int id { get; set; }
        public string dersadi { get; set; }
        public string derskodu { get; set; }
        public string ogrele { get; set; }
        public string bolum { get; set; }
        public string tarih { get; set; }
        public string saat { get; set; }
        public int ogrencisayisi { get; set; }
        public string derslik { get; set; }
    }
}
