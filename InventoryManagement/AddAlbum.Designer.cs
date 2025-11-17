namespace InventoryManagement
{
    partial class AddAlbum
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
            textBoxAlbumName = new TextBox();
            textBoxArtist = new TextBox();
            textBoxYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // textBoxAlbumName
            // 
            textBoxAlbumName.Location = new Point(294, 131);
            textBoxAlbumName.Name = "textBoxAlbumName";
            textBoxAlbumName.Size = new Size(100, 23);
            textBoxAlbumName.TabIndex = 0;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(294, 160);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(100, 23);
            textBoxArtist.TabIndex = 0;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(294, 189);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 134);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Album Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 189);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Year Released";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 163);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "Artist";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(306, 235);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // AddAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxArtist);
            Controls.Add(textBoxAlbumName);
            Name = "AddAlbum";
            Text = "AddAlbum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAlbumName;
        private TextBox textBoxArtist;
        private TextBox textBoxYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSubmit;
    }
}