using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_praktikum
{
        public class RumahSakit
        {
            private List<Orang> daftarOrang;

            public string NamaRumahSakit { get; set; }

            public RumahSakit(string namaRumahSakit)
            {
                NamaRumahSakit = namaRumahSakit;
                daftarOrang = new List<Orang>();
            }

            // Aggregation
            public void TambahOrang(Orang orang)
            {
                if (orang != null)
                {
                    daftarOrang.Add(orang);
                }
            }

            public void DaftarOrang()
            {
                Console.WriteLine();
                Console.WriteLine("===== DAFTAR ORANG DI RUMAH SAKIT =====");

                foreach (Orang orang in daftarOrang)
                {
                    orang.InfoOrang();
                    Console.WriteLine("-----------------------------");
                }
            }

            public void JalankanAktivitas()
            {
                Console.WriteLine();
                Console.WriteLine("===== POLYMORPHISM =====");

                foreach (Orang orang in daftarOrang)
                {
                    orang.Aktivitas();
                }
            }
        }
    }
