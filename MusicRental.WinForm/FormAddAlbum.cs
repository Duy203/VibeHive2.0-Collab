using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicRental.Winforms.Services;
using VibeHive.Common.DTOs;


namespace MusicRental.WinForm
{
    public partial class FormAddAlbum : Form
    {
        private readonly APIClient _api;
        public FormAddAlbum()
        {
            InitializeComponent();
            _api = new APIClient();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            var dto = new MusicDto
            {
               Title = txt_bx_title.Text,
               Artist = txt_bx_artist.Text,
                Genre = txt_bx_genre.Text,
                Year = int.Parse(txt_bx_year.Text)
            };

            var created = await _api.AddMusic(dto);
            MessageBox.Show($"Album '{created.Title}' by {created.Artist} added with ID: {created.Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
