using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaylistBuilder.WinForms.services;
using System;
using System.Windows.Forms;
using VibeHive.Common.DTOs;

namespace PlaylistBuilder.WinForms
{
    public partial class FormVoteSong : Form
    {
        private readonly ApiClient _api;
        public FormVoteSong()
        {
            InitializeComponent();
            _api = new ApiClient();
        }

        private async void btn_vote_Click(object sender, EventArgs e)
        {
            int playlistid = int.Parse(txt_bx_playlistid.Text);

            var dto = new VoteDto
            {
                SongId = int.Parse(txt_bx_songid.Text)
            };

            var song = await _api.Vote(playlistid, dto);

            MessageBox.Show($"Voted for song with ID: {song.Id} in playlist {playlistid}");
            Close();
        }
    }
}
