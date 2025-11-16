using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicRental.Winforms.Services;
using VibeHive.Common.DTOs;

namespace MusicRental.WinForm
{
    public partial class FormRentAlbum : Form
    {
        private readonly APIClient _api;

        public FormRentAlbum()
        {
            InitializeComponent();
            _api = new APIClient();
        }

        private async void btn_rent_album_Click(object sender, EventArgs e)
        {
            var dto = new RentAlbumDto
            {
                UserId = int.Parse(txt_bx_userid.Text),
                AlbumId = int.Parse(txt_bx_albumid.Text)
            };

            var rental = await _api.RentAlbum(dto);
            if (rental == null)
            {
                MessageBox.Show("Album not available");
                return;
            }

            MessageBox.Show($"Album rented; Rental ID {rental.Id}");
            Close();
        }
    }
}
