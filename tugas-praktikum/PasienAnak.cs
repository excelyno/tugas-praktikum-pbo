using tugas_praktikum;
    public class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan)
            : base(nama, umur, keluhan)
        {
        }

        public void Menangis()
        {
            Console.WriteLine($"{Nama} sedang menangis karena takut diperiksa.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien anak {Nama} sedang ditemani orang tua.");
        }
    }