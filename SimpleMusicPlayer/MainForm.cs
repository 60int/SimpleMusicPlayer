using MusicPlayerTest;
using System.Text;

namespace SimpleMusicPlayer
{
    public partial class MainForm : Form
    {
        static readonly List<Song> Songs = new();

        public static readonly Random rnd1 = new();

        public List<string> Playlist { get; set; }

        public ListPlayer Player { get; set; }

        public MainForm()
        {
            InitializeComponent();
            foreach (var item in File.ReadAllLines("songs.csv", Encoding.UTF8))
            {
                Song song = new(item);
                Songs.Add(song);
            }
            Playlist = new List<string>()
            {

                Songs[0].SongFilePath.ToString(),
                Songs[1].SongFilePath.ToString(),
                Songs[2].SongFilePath.ToString(),
                Songs[3].SongFilePath.ToString(),
                Songs[4].SongFilePath.ToString(),
                Songs[5].SongFilePath.ToString(),
                Songs[6].SongFilePath.ToString(),
                Songs[7].SongFilePath.ToString(),
                Songs[8].SongFilePath.ToString(),
                Songs[9].SongFilePath.ToString(),
                Songs[10].SongFilePath.ToString(),
                Songs[0].SongFilePath.ToString(),
                Songs[1].SongFilePath.ToString(),
                Songs[2].SongFilePath.ToString(),
                Songs[3].SongFilePath.ToString(),
                Songs[4].SongFilePath.ToString(),
                Songs[5].SongFilePath.ToString(),
                Songs[6].SongFilePath.ToString(),
                Songs[7].SongFilePath.ToString(),
                Songs[8].SongFilePath.ToString(),
                Songs[9].SongFilePath.ToString(),
                Songs[10].SongFilePath.ToString()
            }.OrderBy(a => rnd1.Next()).ToList();

            listBox1.DataSource = Playlist;

            Player = new ListPlayer(Playlist);

            //Attach event handler that sets the text of the label called _nowPlayingLabel
            //Remove directory and file extension from file name
            Player.NowPlaying += (s, e) => SongNameLabel.Text = e?.Replace(".mp3", "");
            --listBox1.SelectedIndex;
            Player.NowPlaying += (s, e) => listBox1.SelectedIndex++;
        }

    private void PlayButton_Click(object sender, EventArgs e)
        {
            Player.PlaySong();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Player.PauseSong();
        }

        private void NextSongButton_Click(object sender, EventArgs e)
        {
            Player.NextSong();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listBox1.Refresh();
        }
    }
}