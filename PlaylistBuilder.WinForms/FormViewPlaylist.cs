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

namespace PlaylistBuilder.WinForms
{
    public partial class FormViewPlaylist : Form
    {
        private readonly ApiClient _api;
        public FormViewPlaylist()
        {
            InitializeComponent();
            _api = new ApiClient();
        }

        private async void FormViewPlaylist_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _api.GetAllPlaylists();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _api.GetAllPlaylists();
        }
    }
}
