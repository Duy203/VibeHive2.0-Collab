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
    public partial class FormReturnAlbum : Form
    {
        private readonly APIClient _api;
        public FormReturnAlbum()
        {
            InitializeComponent();
            _api = new APIClient();
        }

        private async void btn_return_rental_Click(object sender, EventArgs e)
        {
            int rentalid = int.Parse(txt_bx_rentalid.Text);
            var result = await _api.ReturnAlbum(rentalid);

            if (!result)
            {
                MessageBox.Show("Invalid Rental ID");
                return;
            }
            MessageBox.Show("Album returned successfully");
            Close();

        }
    }
}
