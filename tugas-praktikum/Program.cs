using System;
using tugas_praktikum;

namespace tugas_praktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // MEMBUAT OBJEK RUMAH SAKIT
            // ==========================================

            RumahSakit rumahSakit =
                new RumahSakit("RS Sehat Bersama");


            // ==========================================
            // MEMBUAT OBJEK
            // ==========================================

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


            // ==========================================
            // AGGREGATION
            // ==========================================

            rumahSakit.TambahOrang(dokter);
            rumahSakit.TambahOrang(perawat);
            rumahSakit.TambahOrang(pasienAnak);
            rumahSakit.TambahOrang(pasienDewasa);


            // ==========================================
            // MENAMPILKAN SEMUA DATA
            // ==========================================

            rumahSakit.DaftarOrang();


            // ==========================================
            // POLYMORPHISM
            // ==========================================

            rumahSakit.JalankanAktivitas();


            // ==========================================
            // METHOD KHUSUS DOKTER
            // ==========================================

            Console.WriteLine();
            Console.WriteLine("===== METHOD KHUSUS =====");

            dokter.CekSpesialis();
            dokter.TugasUtama();

            dokter.Diagnosa(pasienDewasa);


            // ==========================================
            // METHOD KHUSUS PERAWAT
            // ==========================================

            perawat.CekSpesialis();
            perawat.TugasUtama();

            perawat.CekPasien(pasienAnak);


            // ==========================================
            // METHOD KHUSUS PASIEN
            // ==========================================

            pasienAnak.CekKeluhan();
            pasienAnak.Menangis();

            pasienDewasa.CekKeluhan();
            pasienDewasa.Konsultasi();


            // ==========================================
            // MENAMPILKAN REKAM MEDIS
            // ==========================================

            Console.WriteLine();
            Console.WriteLine("===== REKAM MEDIS PASIEN DEWASA =====");

            pasienDewasa.RekamMedis.TampilkanRekamMedis();


            // ==========================================
            // SOAL NOMOR 5
            // POLYMORPHISM
            // ==========================================

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