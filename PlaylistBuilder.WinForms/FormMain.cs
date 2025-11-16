using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistBuilder.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_create_playlist_Click(object sender, EventArgs e)
        {
            new FormCreatePlaylist().ShowDialog();
        }

        private void btn_view_playlist_Click(object sender, EventArgs e)
        {
            new FormViewPlaylist().ShowDialog();
        }

        private void btn_add_playlist_Click(object sender, EventArgs e)
        {
            new FormAddSong().ShowDialog();
        }

        private void btn_invite_user_Click(object sender, EventArgs e)
        {
            new FormInviteUser().ShowDialog();
        }

        private void btn_vote_Click(object sender, EventArgs e)
        {
            new FormVoteSong().ShowDialog();
        }

        private void btn_view_ranking_Click(object sender, EventArgs e)
        {
            new FormRankings().ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
