namespace MusicRental.WinForm
{
    partial class FormReturnAlbum
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
            txt_bx_rentalid = new TextBox();
            btn_return_rental = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 101);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "Rental ID";
            // 
            // txt_bx_rentalid
            // 
            txt_bx_rentalid.Location = new Point(487, 101);
            txt_bx_rentalid.Name = "txt_bx_rentalid";
            txt_bx_rentalid.Size = new Size(200, 39);
            txt_bx_rentalid.TabIndex = 1;
            // 
            // btn_return_rental
            // 
            btn_return_rental.Location = new Point(473, 188);
            btn_return_rental.Name = "btn_return_rental";
            btn_return_rental.Size = new Size(214, 59);
            btn_return_rental.TabIndex = 2;
            btn_return_rental.Text = "Return Rental";
            btn_return_rental.UseVisualStyleBackColor = true;
            btn_return_rental.Click += btn_return_rental_Click;
            // 
            // FormReturnAlbum
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 505);
            Controls.Add(btn_return_rental);
            Controls.Add(txt_bx_rentalid);
            Controls.Add(label1);
            Name = "FormReturnAlbum";
            Text = "FormReturnAlbum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_bx_rentalid;
        private Button btn_return_rental;
    }
}