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
            
            Playlist = new List<string>();

            for (int i = 0; i < 15; i++)
            {
                Playlist.Add(Songs[i].SongFilePath.ToString());
            }

            for (int i = Playlist.Count - 1; i > 0; i--)
            {
                int j = rnd1.Next(i + 1);
                string temp = Playlist[i];
                Playlist[i] = Playlist[j];
                Playlist[j] = temp;
            }

            listBox1.DataSource = Playlist;

            Player = new PlayrList(Playlist);

            //Attach event handler that sets the text of the label called _nowPlayingLabel
            //Remove directory and file extension from file name
            Player.NowPlaying += (s, e) => SongNameLabel.Text = e?.Replace(".mp3", "");
            --SongsListBox.SelectedIndex;
            Player.NowPlaying += (s, e) => SongsListBox.SelectedIndex++;
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
            SongsListBox.Refresh();
        }
    }
}
