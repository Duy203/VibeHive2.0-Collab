namespace MusicRental.WinForm
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
            btn_add_album = new Button();
            btn_list_album = new Button();
            btn_rent_album = new Button();
            btn_return_album = new Button();
            btn_view_rental = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_add_album
            // 
            btn_add_album.Location = new Point(57, 46);
            btn_add_album.Name = "btn_add_album";
            btn_add_album.Size = new Size(150, 46);
            btn_add_album.TabIndex = 0;
            btn_add_album.Text = "Add Album";
            btn_add_album.UseVisualStyleBackColor = true;
            btn_add_album.Click += btn_add_album_Click;
            // 
            // btn_list_album
            // 
            btn_list_album.Location = new Point(57, 145);
            btn_list_album.Name = "btn_list_album";
            btn_list_album.Size = new Size(150, 46);
            btn_list_album.TabIndex = 1;
            btn_list_album.Text = "List Album";
            btn_list_album.UseVisualStyleBackColor = true;
            btn_list_album.Click += btn_list_album_Click;
            // 
            // btn_rent_album
            // 
            btn_rent_album.Location = new Point(57, 229);
            btn_rent_album.Name = "btn_rent_album";
            btn_rent_album.Size = new Size(150, 46);
            btn_rent_album.TabIndex = 2;
            btn_rent_album.Text = "Rent Album";
            btn_rent_album.UseVisualStyleBackColor = true;
            btn_rent_album.Click += btn_rent_album_Click;
            // 
            // btn_return_album
            // 
            btn_return_album.Location = new Point(57, 314);
            btn_return_album.Name = "btn_return_album";
            btn_return_album.Size = new Size(191, 46);
            btn_return_album.TabIndex = 3;
            btn_return_album.Text = "Return Album";
            btn_return_album.UseVisualStyleBackColor = true;
            btn_return_album.Click += btn_return_album_Click;
            // 
            // btn_view_rental
            // 
            btn_view_rental.Location = new Point(57, 388);
            btn_view_rental.Name = "btn_view_rental";
            btn_view_rental.Size = new Size(228, 46);
            btn_view_rental.TabIndex = 4;
            btn_view_rental.Text = "View Active Rental";
            btn_view_rental.UseVisualStyleBackColor = true;
            btn_view_rental.Click += btn_view_rental_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(57, 468);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(150, 46);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 771);
            Controls.Add(btn_exit);
            Controls.Add(btn_view_rental);
            Controls.Add(btn_return_album);
            Controls.Add(btn_rent_album);
            Controls.Add(btn_list_album);
            Controls.Add(btn_add_album);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_album;
        private Button btn_list_album;
        private Button btn_rent_album;
        private Button btn_return_album;
        private Button btn_view_rental;
        private Button btn_exit;
    }
}