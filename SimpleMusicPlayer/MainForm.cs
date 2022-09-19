using MusicPlayerTest;
using SimpleMusicPlayer.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SimpleMusicPlayer
{
    public partial class MainForm : Form
    {
        static readonly List<Song> Songs = new List<Song>();

        public static readonly Random rnd1 = new Random();

        public List<string> Playlist { get; set; }

        public ListPlayer Player { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Resources.songs.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList().ForEach(a => Songs.Add(new Song(a)));

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
                Songs[11].SongFilePath.ToString(),
                Songs[12].SongFilePath.ToString(),
                Songs[13].SongFilePath.ToString(),
                Songs[14].SongFilePath.ToString(),
                Songs[15].SongFilePath.ToString(),
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
                Songs[11].SongFilePath.ToString(),
                Songs[12].SongFilePath.ToString(),
                Songs[13].SongFilePath.ToString(),
                Songs[14].SongFilePath.ToString(),
                Songs[15].SongFilePath.ToString()
            }.OrderBy(a => rnd1.Next()).ToList();

            listBox1.DataSource = Playlist;

            Player = new ListPlayer(Playlist);

            //Attach event handler that sets the text of the label called _nowPlayingLabel
            //Remove directory and file extension from file name
            Player.NowPlaying += (s, e) => SongNameLabel.Text = e?.Split('\\').Skip(5).FirstOrDefault()?.Replace(".mp3", "");
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
    }
}