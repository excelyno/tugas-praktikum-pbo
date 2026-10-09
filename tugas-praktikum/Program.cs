using System;
using tugas_praktikum;

namespace tugas_praktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object rumahSakit

            RumahSakit rumahSakit =
                new RumahSakit("RS Sehat Bersama");


            // object Dokter
            Dokter dokter =
                new Dokter(
                    "Dr. Budi",
                    35,
                    "Penyakit Dalam"
                );

            Perawat perawat =
                new Perawat(
                    "Siti",
                    28,
                    "Keperawatan Umum"
                );

            PasienAnak pasienAnak =
                new PasienAnak(
                    "Andi",
                    8,
                    "Demam"
                );

            PasienDewasa pasienDewasa =
                new PasienDewasa(
                    "Rina",
                    25,
                    "Sakit kepala"
                );


            rumahSakit.TambahOrang(dokter);
            rumahSakit.TambahOrang(perawat);
            rumahSakit.TambahOrang(pasienAnak);
            rumahSakit.TambahOrang(pasienDewasa);


            rumahSakit.DaftarOrang();

            rumahSakit.JalankanAktivitas();

            Console.WriteLine();
            Console.WriteLine("===== METHOD KHUSUS =====");

            dokter.CekSpesialis();
            dokter.TugasUtama();

            dokter.Diagnosa(pasienDewasa);


            perawat.CekSpesialis();
            perawat.TugasUtama();

            perawat.CekPasien(pasienAnak);


            pasienAnak.CekKeluhan();
            pasienAnak.Menangis();

            pasienDewasa.CekKeluhan();
            pasienDewasa.Konsultasi();


            Console.WriteLine();
            Console.WriteLine("===== REKAM MEDIS PASIEN DEWASA =====");

            pasienDewasa.RekamMedis.TampilkanRekamMedis();


            Console.WriteLine();
            Console.WriteLine("===== VARIABEL ORANG BERISI PERAWAT =====");

            Orang orang = perawat;

            orang.Aktivitas();


            Console.WriteLine();
            Console.WriteLine("Program selesai.");
            Console.ReadKey();
        }
    }
}
