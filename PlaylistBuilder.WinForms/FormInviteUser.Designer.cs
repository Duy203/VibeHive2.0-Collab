namespace PlaylistBuilder.WinForms
{
    partial class FormInviteUser
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
            label2 = new Label();
            txt_bx_playlistid = new TextBox();
            txt_bx_userid = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 130);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 0;
            label1.Text = "Playlist ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 203);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 1;
            label2.Text = "User ID ";
            // 
            // txt_bx_playlistid
            // 
            txt_bx_playlistid.Location = new Point(284, 127);
            txt_bx_playlistid.Name = "txt_bx_playlistid";
            txt_bx_playlistid.Size = new Size(200, 39);
            txt_bx_playlistid.TabIndex = 2;
            // 
            // txt_bx_userid
            // 
            txt_bx_userid.Location = new Point(284, 196);
            txt_bx_userid.Name = "txt_bx_userid";
            txt_bx_userid.Size = new Size(200, 39);
            txt_bx_userid.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(284, 274);
            button1.Name = "button1";
            button1.Size = new Size(150, 41);
            button1.TabIndex = 4;
            button1.Text = "Invite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormInviteUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 645);
            Controls.Add(button1);
            Controls.Add(txt_bx_userid);
            Controls.Add(txt_bx_playlistid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInviteUser";
            Text = "FormInviteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_bx_playlistid;
        private TextBox txt_bx_userid;
        private Button button1;
    }
}