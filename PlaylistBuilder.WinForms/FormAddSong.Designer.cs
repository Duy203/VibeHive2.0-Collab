namespace PlaylistBuilder.WinForms
{
    partial class FormAddSong
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
            txt_bx_title = new TextBox();
            txt_bx_artist = new TextBox();
            txt_bx_genre = new TextBox();
            txt_bx_duration = new TextBox();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt_bx_playlistid
            // 
            txt_bx_playlistid.Location = new Point(466, 60);
            txt_bx_playlistid.Name = "txt_bx_playlistid";
            txt_bx_playlistid.Size = new Size(241, 39);
            txt_bx_playlistid.TabIndex = 0;
            // 
            // txt_bx_title
            // 
            txt_bx_title.Location = new Point(466, 139);
            txt_bx_title.Name = "txt_bx_title";
            txt_bx_title.Size = new Size(241, 39);
            txt_bx_title.TabIndex = 1;
            // 
            // txt_bx_artist
            // 
            txt_bx_artist.Location = new Point(466, 214);
            txt_bx_artist.Name = "txt_bx_artist";
            txt_bx_artist.Size = new Size(241, 39);
            txt_bx_artist.TabIndex = 2;
            // 
            // txt_bx_genre
            // 
            txt_bx_genre.Location = new Point(466, 295);
            txt_bx_genre.Name = "txt_bx_genre";
            txt_bx_genre.Size = new Size(241, 39);
            txt_bx_genre.TabIndex = 3;
            // 
            // txt_bx_duration
            // 
            txt_bx_duration.Location = new Point(466, 375);
            txt_bx_duration.Name = "txt_bx_duration";
            txt_bx_duration.Size = new Size(241, 39);
            txt_bx_duration.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(497, 448);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(185, 46);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 60);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 6;
            label1.Text = "Playlist ID  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 142);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 7;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 214);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 8;
            label3.Text = "Artist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 295);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 9;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 375);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 10;
            label5.Text = "Duration";
            // 
            // FormAddSong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 686);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(txt_bx_duration);
            Controls.Add(txt_bx_genre);
            Controls.Add(txt_bx_artist);
            Controls.Add(txt_bx_title);
            Controls.Add(txt_bx_playlistid);
            Name = "FormAddSong";
            Text = "FormAddSong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_bx_playlistid;
        private TextBox txt_bx_title;
        private TextBox txt_bx_artist;
        private TextBox txt_bx_genre;
        private TextBox txt_bx_duration;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}