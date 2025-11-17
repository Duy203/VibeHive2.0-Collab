namespace InventoryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_addAlbum = new Button();
            btn_getAlbum = new Button();
            btn_updateAlbum = new Button();
            btn_deleteAlbum = new Button();
            btn_listAlbums = new Button();
            SuspendLayout();
            // 
            // btn_addAlbum
            // 
            btn_addAlbum.Font = new Font("Segoe UI", 14F);
            btn_addAlbum.Location = new Point(263, 85);
            btn_addAlbum.Name = "btn_addAlbum";
            btn_addAlbum.Size = new Size(219, 53);
            btn_addAlbum.TabIndex = 0;
            btn_addAlbum.Text = "Add Album";
            btn_addAlbum.UseVisualStyleBackColor = true;
            btn_addAlbum.Click += btn_addAlbum_Click;
            // 
            // btn_getAlbum
            // 
            btn_getAlbum.Font = new Font("Segoe UI", 14F);
            btn_getAlbum.Location = new Point(263, 144);
            btn_getAlbum.Name = "btn_getAlbum";
            btn_getAlbum.Size = new Size(219, 53);
            btn_getAlbum.TabIndex = 0;
            btn_getAlbum.Text = "Get Album";
            btn_getAlbum.UseVisualStyleBackColor = true;
            btn_getAlbum.Click += btn_getAlbum_Click;
            // 
            // btn_updateAlbum
            // 
            btn_updateAlbum.Font = new Font("Segoe UI", 14F);
            btn_updateAlbum.Location = new Point(263, 203);
            btn_updateAlbum.Name = "btn_updateAlbum";
            btn_updateAlbum.Size = new Size(219, 53);
            btn_updateAlbum.TabIndex = 0;
            btn_updateAlbum.Text = "Update Album";
            btn_updateAlbum.UseVisualStyleBackColor = true;
            btn_updateAlbum.Click += btn_updateAlbum_Click;
            // 
            // btn_deleteAlbum
            // 
            btn_deleteAlbum.Font = new Font("Segoe UI", 14F);
            btn_deleteAlbum.Location = new Point(263, 262);
            btn_deleteAlbum.Name = "btn_deleteAlbum";
            btn_deleteAlbum.Size = new Size(219, 53);
            btn_deleteAlbum.TabIndex = 0;
            btn_deleteAlbum.Text = "Delete Album";
            btn_deleteAlbum.UseVisualStyleBackColor = true;
            btn_deleteAlbum.Click += btn_deleteAlbum_Click;
            // 
            // btn_listAlbums
            // 
            btn_listAlbums.Font = new Font("Segoe UI", 14F);
            btn_listAlbums.Location = new Point(263, 321);
            btn_listAlbums.Name = "btn_listAlbums";
            btn_listAlbums.Size = new Size(219, 53);
            btn_listAlbums.TabIndex = 0;
            btn_listAlbums.Text = "List Albums";
            btn_listAlbums.UseVisualStyleBackColor = true;
            btn_listAlbums.Click += btn_listAlbums_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_listAlbums);
            Controls.Add(btn_deleteAlbum);
            Controls.Add(btn_updateAlbum);
            Controls.Add(btn_getAlbum);
            Controls.Add(btn_addAlbum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_addAlbum;
        private Button btn_getAlbum;
        private Button btn_updateAlbum;
        private Button btn_deleteAlbum;
        private Button btn_listAlbums;
    }
}
