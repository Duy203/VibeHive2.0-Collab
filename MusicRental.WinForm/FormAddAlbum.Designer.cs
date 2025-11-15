namespace MusicRental.WinForm
{
    partial class FormAddAlbum
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
            txt_bx_title = new TextBox();
            txt_bx_artist = new TextBox();
            txt_bx_genre = new TextBox();
            txt_bx_year = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            SuspendLayout();
            // 
            // txt_bx_title
            // 
            txt_bx_title.Location = new Point(121, 73);
            txt_bx_title.Name = "txt_bx_title";
            txt_bx_title.Size = new Size(230, 39);
            txt_bx_title.TabIndex = 0;
            // 
            // txt_bx_artist
            // 
            txt_bx_artist.Location = new Point(121, 145);
            txt_bx_artist.Name = "txt_bx_artist";
            txt_bx_artist.Size = new Size(230, 39);
            txt_bx_artist.TabIndex = 1;
            // 
            // txt_bx_genre
            // 
            txt_bx_genre.Location = new Point(121, 222);
            txt_bx_genre.Name = "txt_bx_genre";
            txt_bx_genre.Size = new Size(230, 39);
            txt_bx_genre.TabIndex = 2;
            // 
            // txt_bx_year
            // 
            txt_bx_year.Location = new Point(121, 298);
            txt_bx_year.Name = "txt_bx_year";
            txt_bx_year.Size = new Size(230, 39);
            txt_bx_year.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 5;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 6;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 298);
            label4.Name = "label4";
            label4.Size = new Size(58, 32);
            label4.TabIndex = 7;
            label4.Text = "Year";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(135, 370);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(150, 46);
            btn_add.TabIndex = 8;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // FormAddAlbum
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 649);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_bx_year);
            Controls.Add(txt_bx_genre);
            Controls.Add(txt_bx_artist);
            Controls.Add(txt_bx_title);
            Name = "FormAddAlbum";
            Text = "FormAddAlbum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_bx_title;
        private TextBox txt_bx_artist;
        private TextBox txt_bx_genre;
        private TextBox txt_bx_year;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
    }
}