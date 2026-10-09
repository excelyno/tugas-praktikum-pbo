using tugas_praktikum;
    public class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi)
            : base(nama, umur, spesialisasi)
        {
        }

        // Association dengan Pasien
        public void Diagnosa(Pasien pasien)
        {
            Console.WriteLine(
                $"Dokter {Nama} sedang mendiagnosa pasien {pasien.Nama}."
            );

            pasien.RekamMedis.HasilDiagnosa =
                $"Diagnosa oleh Dr. {Nama}: perlu pemeriksaan lebih lanjut.";
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Dokter {Nama} sedang memeriksa pasien.");
        }

        public override void TugasUtama()
        {
            Console.WriteLine($"Dokter {Nama} bertugas melakukan pemeriksaan dan diagnosa.");
        }
    }