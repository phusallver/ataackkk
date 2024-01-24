namespace atk
{
    public class Dagangan
    {
        private string nama { get; set; }
        private int harga { get; set; }

        public Dagangan() { }
        public Dagangan(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }
    }
}
