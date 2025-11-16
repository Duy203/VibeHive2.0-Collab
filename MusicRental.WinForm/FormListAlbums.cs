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

namespace MusicRental.WinForm
{
    public partial class FormListAlbums : Form
    {
        private readonly APIClient _api;
        public FormListAlbums()
        {
            InitializeComponent();
            _api = new APIClient();
        }

        private async void FormListAlbums_Load(object sender, EventArgs e)
        {
            dgv_album.DataSource = await _api.GetAllMusic();
        }

        private async void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_album.DataSource = await _api.GetAllMusic();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_album.CurrentRow == null) return;
            
            int id = (int)dgv_album.CurrentRow.Cells["Id"].Value;
            await _api.DelMusic(id);

            dgv_album.DataSource = await _api.GetAllMusic();
        }
    }
}
