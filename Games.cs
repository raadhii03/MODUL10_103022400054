namespace MODUL10_103022400054
{
    public class Games
    {
        public int id { get; set; }
        public string Nama { get; set; }
        public string Developer { get; set; }
        public int TahunRilis { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public List<string> Platform { get; set; }
        public List<string> Mode { get; set; }
        public bool isOnline { get; set; }
        public bool IsOnline { get; internal set; }
        public int Harga { get; set; }
    }
}
