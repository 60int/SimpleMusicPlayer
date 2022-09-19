using NAudio.Wave;

namespace MusicPlayerTest
{
    public class ListPlayer
    {
        //create an event
        public event EventHandler<string> NowPlaying;

        private Queue<string> playlist;
        private IWavePlayer player;
        private WaveStream fileWaveStream;
        public ListPlayer(List<string>? startingPlaylist)
        {
            playlist = new Queue<string>(startingPlaylist!);
        }
        public void PlaySong()
        {
            if (playlist.Count < 1)
            {
                return;
            }

            if (player != null && player.PlaybackState != PlaybackState.Stopped)
            {
                player.Stop();
            }
            if (fileWaveStream != null)
            {
                fileWaveStream.Dispose();
            }
            if (player != null)
            {
                player.Dispose();
                player = null!;
            }

            var f = playlist.Dequeue();

            player = new WaveOutEvent();
            fileWaveStream = new AudioFileReader(f);
            player.Init(fileWaveStream);
            player.PlaybackStopped += (sender, evn) => { PlaySong(); };
            player.Play();

            var e = NowPlaying;
            e?.Invoke(this, f);
        }
        public void PauseSong()
        {
            if (player != null)
            {
                if (player.PlaybackState == PlaybackState.Playing)
                {
                    player.Pause();
                }
                else if (player.PlaybackState == PlaybackState.Paused)
                {
                    player.Play();
                }
            }
        }
        public void NextSong()
        {
            try
            {
                player.Dispose();
                player = null!;
                fileWaveStream.Dispose();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't play Next Song", ex);
            }
        }
    }
}
