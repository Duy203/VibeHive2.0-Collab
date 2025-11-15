using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRental.WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_add_album_Click(object sender, EventArgs e)
        {
            new FormAddAlbum().ShowDialog();
        }

        private void btn_list_album_Click(object sender, EventArgs e)
        {
            new FormListAlbums().ShowDialog();
        }

        private void btn_rent_album_Click(object sender, EventArgs e)
        {
            new FormRentAlbum().ShowDialog();
        }

        private void btn_return_album_Click(object sender, EventArgs e)
        {
            new FormReturnAlbum().ShowDialog();
        }

        private void btn_view_rental_Click(object sender, EventArgs e)
        {
            new FormActiveRentals().ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
