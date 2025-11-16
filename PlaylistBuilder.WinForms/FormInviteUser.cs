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
using VibeHive.Common.DTOs;
using System.Windows.Forms;

namespace PlaylistBuilder.WinForms
{
    public partial class FormInviteUser : Form
    {
        private readonly ApiClient _api;
        public FormInviteUser()
        {
            InitializeComponent();
            _api = new ApiClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dto = new InviteDto
            {
                UserId = int.Parse(txt_bx_userid.Text)

            };
            int playlistId = int.Parse(txt_bx_playlistid.Text);
            await _api.Invite(playlistId, dto);

            MessageBox.Show("User invited successfully!");
            Close();
        }
    }
}
