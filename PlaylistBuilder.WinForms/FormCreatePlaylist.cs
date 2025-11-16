using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VibeHive.Common.DTOs;
using System.Windows.Forms;
using PlaylistBuilder.WinForms.services;
using System.Runtime.CompilerServices;

namespace PlaylistBuilder.WinForms
{
    public partial class FormCreatePlaylist : Form
    {
        private readonly ApiClient _api;
        public FormCreatePlaylist()
        {
            InitializeComponent();
            _api = new ApiClient();
        }

        private async void btn_create_Click(object sender, EventArgs e)
        {
            var dto = new CreatePlaylistDto
            {
                Name = txt_bx_name.Text,
                CreateBy = int.Parse(txt_bx_userid.Text),
                IsCollab = checkBox1.Checked
            };

            var playlist = await _api.CreatePlaylist(dto);
            MessageBox.Show($"Playlist created! ID= {playlist.Id}");
            Close();
        }
    }
}
