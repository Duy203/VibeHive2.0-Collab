namespace MusicRental.WinForm
{
    partial class FormListAlbums
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
            dgv_album = new DataGridView();
            btn_refresh = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_album).BeginInit();
            SuspendLayout();
            // 
            // dgv_album
            // 
            dgv_album.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_album.Location = new Point(55, 98);
            dgv_album.Name = "dgv_album";
            dgv_album.RowHeadersWidth = 82;
            dgv_album.Size = new Size(710, 300);
            dgv_album.TabIndex = 0;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(55, 449);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(150, 56);
            btn_refresh.TabIndex = 1;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(554, 440);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(150, 56);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // FormListAlbums
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 708);
            Controls.Add(btn_delete);
            Controls.Add(btn_refresh);
            Controls.Add(dgv_album);
            Name = "FormListAlbums";
            Text = "FormListAlbums";
            ((System.ComponentModel.ISupportInitialize)dgv_album).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_album;
        private Button btn_refresh;
        private Button btn_delete;
    }
}