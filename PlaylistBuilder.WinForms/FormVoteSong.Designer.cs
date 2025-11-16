namespace PlaylistBuilder.WinForms
{
    partial class FormVoteSong
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
            txt_bx_playlistid = new TextBox();
            txt_bx_songid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_vote = new Button();
            SuspendLayout();
            // 
            // txt_bx_playlistid
            // 
            txt_bx_playlistid.Location = new Point(467, 107);
            txt_bx_playlistid.Name = "txt_bx_playlistid";
            txt_bx_playlistid.Size = new Size(200, 39);
            txt_bx_playlistid.TabIndex = 0;
            // 
            // txt_bx_songid
            // 
            txt_bx_songid.Location = new Point(467, 200);
            txt_bx_songid.Name = "txt_bx_songid";
            txt_bx_songid.Size = new Size(200, 39);
            txt_bx_songid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 110);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 2;
            label1.Text = "PLaylist ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 200);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 3;
            label2.Text = "Song ID";
            // 
            // btn_vote
            // 
            btn_vote.Location = new Point(486, 287);
            btn_vote.Name = "btn_vote";
            btn_vote.Size = new Size(150, 46);
            btn_vote.TabIndex = 4;
            btn_vote.Text = "Vote";
            btn_vote.UseVisualStyleBackColor = true;
            btn_vote.Click += btn_vote_Click;
            // 
            // FormVoteSong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 667);
            Controls.Add(btn_vote);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_bx_songid);
            Controls.Add(txt_bx_playlistid);
            Name = "FormVoteSong";
            Text = "FormVoteSong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_bx_playlistid;
        private TextBox txt_bx_songid;
        private Label label1;
        private Label label2;
        private Button btn_vote;
    }
}