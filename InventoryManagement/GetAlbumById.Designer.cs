namespace InventoryManagement
{
    partial class GetAlbumById
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
            label1 = new Label();
            textBoxAlbumId = new TextBox();
            button_Submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 137);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Album ID:";
            // 
            // textBoxAlbumId
            // 
            textBoxAlbumId.Location = new Point(326, 134);
            textBoxAlbumId.Name = "textBoxAlbumId";
            textBoxAlbumId.Size = new Size(100, 23);
            textBoxAlbumId.TabIndex = 1;
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(326, 188);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(75, 23);
            button_Submit.TabIndex = 2;
            button_Submit.Text = "Submit";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // GetAlbumById
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Submit);
            Controls.Add(textBoxAlbumId);
            Controls.Add(label1);
            Name = "GetAlbumById";
            Text = "GetAlbumById";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAlbumId;
        private Button button_Submit;
    }
}