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

namespace PlaylistBuilder.WinForms
{
    public partial class FormRankings : Form
    {
        private readonly ApiClient _api;
        public FormRankings()
        {
            InitializeComponent();
            _api = new ApiClient();
        }

        private async void btn_load_Click(object sender, EventArgs e)
        {
            int playlistid = int.Parse(textBox1.Text);
            dgv_ranking.DataSource = await _api.GetRankings(playlistid);
        }
    }
}
