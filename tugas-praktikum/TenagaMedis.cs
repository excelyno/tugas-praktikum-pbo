using tugas_praktikum;
    public abstract class TenagaMedis : Orang
    {
        private string spesialisasi;

        public string Spesialisasi
        {
            get { return spesialisasi; }
            set
            {
                spesialisasi = string.IsNullOrWhiteSpace(value)
                    ? "Umum"
                    : value;
            }
        }

        protected TenagaMedis(string nama, int umur, string spesialisasi)
            : base(nama, umur)
        {
            Spesialisasi = spesialisasi;
        }

        public void CekSpesialis()
        {
            Console.WriteLine($"{Nama} memiliki spesialisasi {Spesialisasi}.");
        }

        // Abstraction
        public abstract void TugasUtama();
    }
