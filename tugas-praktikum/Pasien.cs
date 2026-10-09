namespace tugas_praktikum
{
        public class Pasien : Orang
        {
            private string keluhan;

            public string Keluhan
            {
                get { return keluhan; }
                set
                {
                    keluhan = string.IsNullOrWhiteSpace(value)
                        ? "Tidak ada keluhan"
                        : value;
                }
            }

            // Composition
            public RekamMedis RekamMedis { get; private set; }

            public Pasien(string nama, int umur, string keluhan)
                : base(nama, umur)
            {
                Keluhan = keluhan;

                // RekamMedis dibuat bersama objek Pasien
                RekamMedis = new RekamMedis();
            }

            public void CekKeluhan()
            {
                Console.WriteLine($"{Nama} mengeluhkan: {Keluhan}");
            }

            public override void Aktivitas()
            {
                Console.WriteLine($"Pasien {Nama} sedang menunggu pemeriksaan.");
            }

            public override void InfoOrang()
            {
                base.InfoOrang();
                Console.WriteLine($"Keluhan : {Keluhan}");
            }
        }
    }
