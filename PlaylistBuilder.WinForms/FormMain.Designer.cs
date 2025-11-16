namespace PlaylistBuilder.WinForms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_create_playlist = new Button();
            btn_view_playlist = new Button();
            btn_add_playlist = new Button();
            btn_invite_user = new Button();
            btn_vote = new Button();
            btn_view_ranking = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_create_playlist
            // 
            btn_create_playlist.Location = new Point(267, 23);
            btn_create_playlist.Name = "btn_create_playlist";
            btn_create_playlist.Size = new Size(235, 67);
            btn_create_playlist.TabIndex = 0;
            btn_create_playlist.Text = "Create Playlist";
            btn_create_playlist.UseVisualStyleBackColor = true;
            btn_create_playlist.Click += btn_create_playlist_Click;
            // 
            // btn_view_playlist
            // 
            btn_view_playlist.Location = new Point(267, 121);
            btn_view_playlist.Name = "btn_view_playlist";
            btn_view_playlist.Size = new Size(235, 67);
            btn_view_playlist.TabIndex = 1;
            btn_view_playlist.Text = "View Playlist";
            btn_view_playlist.UseVisualStyleBackColor = true;
            btn_view_playlist.Click += btn_view_playlist_Click;
            // 
            // btn_add_playlist
            // 
            btn_add_playlist.Location = new Point(267, 213);
            btn_add_playlist.Name = "btn_add_playlist";
            btn_add_playlist.Size = new Size(235, 67);
            btn_add_playlist.TabIndex = 2;
            btn_add_playlist.Text = "Add Playlist";
            btn_add_playlist.UseVisualStyleBackColor = true;
            btn_add_playlist.Click += btn_add_playlist_Click;
            // 
            // btn_invite_user
            // 
            btn_invite_user.Location = new Point(267, 318);
            btn_invite_user.Name = "btn_invite_user";
            btn_invite_user.Size = new Size(235, 67);
            btn_invite_user.TabIndex = 3;
            btn_invite_user.Text = "Invite User";
            btn_invite_user.UseVisualStyleBackColor = true;
            btn_invite_user.Click += btn_invite_user_Click;
            // 
            // btn_vote
            // 
            btn_vote.Location = new Point(267, 411);
            btn_vote.Name = "btn_vote";
            btn_vote.Size = new Size(230, 67);
            btn_vote.TabIndex = 4;
            btn_vote.Text = "Vote Song";
            btn_vote.UseVisualStyleBackColor = true;
            btn_vote.Click += btn_vote_Click;
            // 
            // btn_view_ranking
            // 
            btn_view_ranking.Location = new Point(267, 506);
            btn_view_ranking.Name = "btn_view_ranking";
            btn_view_ranking.Size = new Size(230, 67);
            btn_view_ranking.TabIndex = 5;
            btn_view_ranking.Text = "View Ranking";
            btn_view_ranking.UseVisualStyleBackColor = true;
            btn_view_ranking.Click += btn_view_ranking_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(272, 600);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(230, 67);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1751, 760);
            Controls.Add(btn_exit);
            Controls.Add(btn_view_ranking);
            Controls.Add(btn_vote);
            Controls.Add(btn_invite_user);
            Controls.Add(btn_add_playlist);
            Controls.Add(btn_view_playlist);
            Controls.Add(btn_create_playlist);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_create_playlist;
        private Button btn_view_playlist;
        private Button btn_add_playlist;
        private Button btn_invite_user;
        private Button btn_vote;
        private Button btn_view_ranking;
        private Button btn_exit;
    }
}