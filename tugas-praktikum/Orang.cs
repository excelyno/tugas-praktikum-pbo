namespace tugas_praktikum
{
    public class Orang
    {
        // Encapsulation
        private string nama;
        private int umur;

        public string Nama
        {
            get { return nama; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    nama = "Tanpa Nama";
                else
                    nama = value;
            }
        }

        public int Umur
        {
            get { return umur; }
            set
            {
                if (value < 0)
                    umur = 0;
                else
                    umur = value;
            }
        }

        public Orang(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas umum.");
        }

        public virtual void InfoOrang()
        {
            Console.WriteLine($"Nama : {Nama}");
            Console.WriteLine($"Umur : {Umur} tahun");
        }
    }
}