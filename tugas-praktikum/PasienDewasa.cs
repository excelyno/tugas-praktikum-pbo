using tugas_praktikum;
    public class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan)
            : base(nama, umur, keluhan)
        {
        }

        public void Konsultasi()
        {
            Console.WriteLine($"{Nama} sedang melakukan konsultasi dengan tenaga medis.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien dewasa {Nama} sedang melakukan konsultasi.");
        }
    }