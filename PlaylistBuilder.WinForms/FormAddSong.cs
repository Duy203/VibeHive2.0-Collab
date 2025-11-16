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
using System.Windows.Forms;
using VibeHive.Common.DTOs;

namespace PlaylistBuilder.WinForms
{
    public partial class FormAddSong : Form
    {
        private readonly ApiClient _api;

        public FormAddSong()
        {
            InitializeComponent();
            _api = new ApiClient();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            int playlistId = int.Parse(txt_bx_playlistid.Text);

            var dto = new AddSongDto
            {
                Title = txt_bx_title.Text,
                Artist = txt_bx_artist.Text,
                Genre = txt_bx_genre.Text,
                Duration = int.Parse(txt_bx_duration.Text)
            };

            var playlist =await _api.AddSong(playlistId, dto);
            MessageBox.Show("Song Added");
            Close();
        }
    }
}
