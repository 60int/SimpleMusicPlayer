namespace SimpleMusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.NextSongButton = new System.Windows.Forms.Button();
            this.SongsListBox = new System.Windows.Forms.ListBox();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.LoadPlayListButton = new System.Windows.Forms.Button();
            this.CurrentPlaylistDisplayLabel = new System.Windows.Forms.Label();
            this.CurrentPlaylistLabel = new System.Windows.Forms.Label();
            this.CurrentSongDisplayLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 79);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(97, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(12, 108);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(97, 23);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // NextSongButton
            // 
            this.NextSongButton.Location = new System.Drawing.Point(12, 137);
            this.NextSongButton.Name = "NextSongButton";
            this.NextSongButton.Size = new System.Drawing.Size(97, 23);
            this.NextSongButton.TabIndex = 2;
            this.NextSongButton.Text = "Next";
            this.NextSongButton.UseVisualStyleBackColor = true;
            this.NextSongButton.Click += new System.EventHandler(this.NextSongButton_Click);
            // 
            // SongsListBox
            // 
            this.SongsListBox.FormattingEnabled = true;
            this.SongsListBox.ItemHeight = 15;
            this.SongsListBox.Location = new System.Drawing.Point(115, 79);
            this.SongsListBox.Name = "SongsListBox";
            this.SongsListBox.Size = new System.Drawing.Size(408, 94);
            this.SongsListBox.TabIndex = 3;
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SongNameLabel.Location = new System.Drawing.Point(222, 45);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(0, 14);
            this.SongNameLabel.TabIndex = 4;
            // 
            // LoadPlayListButton
            // 
            this.LoadPlayListButton.Location = new System.Drawing.Point(12, 12);
            this.LoadPlayListButton.Name = "LoadPlayListButton";
            this.LoadPlayListButton.Size = new System.Drawing.Size(97, 23);
            this.LoadPlayListButton.TabIndex = 5;
            this.LoadPlayListButton.Text = "Load Playlist";
            this.LoadPlayListButton.UseVisualStyleBackColor = true;
            // 
            // CurrentPlaylistDisplayLabel
            // 
            this.CurrentPlaylistDisplayLabel.AutoSize = true;
            this.CurrentPlaylistDisplayLabel.Location = new System.Drawing.Point(115, 16);
            this.CurrentPlaylistDisplayLabel.Name = "CurrentPlaylistDisplayLabel";
            this.CurrentPlaylistDisplayLabel.Size = new System.Drawing.Size(90, 15);
            this.CurrentPlaylistDisplayLabel.TabIndex = 6;
            this.CurrentPlaylistDisplayLabel.Text = "Current Playlist:";
            // 
            // CurrentPlaylistLabel
            // 
            this.CurrentPlaylistLabel.AutoSize = true;
            this.CurrentPlaylistLabel.Location = new System.Drawing.Point(211, 16);
            this.CurrentPlaylistLabel.Name = "CurrentPlaylistLabel";
            this.CurrentPlaylistLabel.Size = new System.Drawing.Size(0, 15);
            this.CurrentPlaylistLabel.TabIndex = 7;
            // 
            // CurrentSongDisplayLabel
            // 
            this.CurrentSongDisplayLabel.AutoSize = true;
            this.CurrentSongDisplayLabel.Location = new System.Drawing.Point(115, 44);
            this.CurrentSongDisplayLabel.Name = "CurrentSongDisplayLabel";
            this.CurrentSongDisplayLabel.Size = new System.Drawing.Size(101, 15);
            this.CurrentSongDisplayLabel.TabIndex = 8;
            this.CurrentSongDisplayLabel.Text = "Currently Playing:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 191);
            this.Controls.Add(this.CurrentSongDisplayLabel);
            this.Controls.Add(this.CurrentPlaylistLabel);
            this.Controls.Add(this.CurrentPlaylistDisplayLabel);
            this.Controls.Add(this.LoadPlayListButton);
            this.Controls.Add(this.SongNameLabel);
            this.Controls.Add(this.SongsListBox);
            this.Controls.Add(this.NextSongButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PlayButton;
        private Button PauseButton;
        private Button NextSongButton;
        private ListBox SongsListBox;
        private Label SongNameLabel;
        private Button LoadPlayListButton;
        private Label CurrentPlaylistDisplayLabel;
        private Label CurrentPlaylistLabel;
        private Label CurrentSongDisplayLabel;
        private OpenFileDialog openFileDialog1;
    }
}