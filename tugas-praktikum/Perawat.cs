using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_praktikum
{
        public class Perawat : TenagaMedis
        {
            public Perawat(string nama, int umur, string spesialisasi)
                : base(nama, umur, spesialisasi)
            {
            }

            // Association dengan Pasien
            public void CekPasien(Pasien pasien)
            {
                Console.WriteLine(
                    $"Perawat {Nama} sedang mengecek kondisi pasien {pasien.Nama}."
                );
            }

            public override void Aktivitas()
            {
                Console.WriteLine($"Perawat {Nama} sedang membantu pemeriksaan pasien.");
            }

            public override void TugasUtama()
            {
                Console.WriteLine($"Perawat {Nama} bertugas membantu perawatan pasien.");
            }
        }

}
