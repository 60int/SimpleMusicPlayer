namespace MusicPlayerTest
{
    public class Song
    {
        public string SongFilePath { get; set; }
        public Song(string line)
        {
            string[] sa = line.Split(';');
            SongFilePath = sa[0];
        }
    }
}
