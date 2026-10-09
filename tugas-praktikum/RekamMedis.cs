namespace tugas_praktikum
{
    public class RekamMedis
    {
        public string RiwayatKeluhan { get; set; }
        public string HasilDiagnosa { get; set; }

        public RekamMedis()
        {
            RiwayatKeluhan = "Belum ada";
            HasilDiagnosa = "Belum ada";
        }

        public void TampilkanRekamMedis()
        {
            Console.WriteLine($"Riwayat Keluhan : {RiwayatKeluhan}");
            Console.WriteLine($"Hasil Diagnosa  : {HasilDiagnosa}");
        }
    }
}