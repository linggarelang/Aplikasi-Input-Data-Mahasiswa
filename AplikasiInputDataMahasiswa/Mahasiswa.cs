using System.Windows.Forms;

namespace AplikasiInputDataMahasiswa
{
    internal class Mahasiswa
    {
        internal object nilaiHuruf;

        public string Nama { get; internal set; }
        public string Nim { get; internal set; }
        public string Kelas { get; internal set; }
        public int Nilai { get; internal set; }
        public string Huruf;
    }
}