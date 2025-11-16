namespace PlaylistBuilder.WinForms
{
    partial class FormCreatePlaylist
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
            checkBox1 = new CheckBox();
            txt_bx_userid = new TextBox();
            btn_create = new Button();
            txt_bx_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(594, 201);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(209, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Is Collaborative";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_bx_userid
            // 
            txt_bx_userid.Location = new Point(342, 106);
            txt_bx_userid.Name = "txt_bx_userid";
            txt_bx_userid.Size = new Size(214, 39);
            txt_bx_userid.TabIndex = 1;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(397, 195);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(150, 46);
            btn_create.TabIndex = 2;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // txt_bx_name
            // 
            txt_bx_name.Location = new Point(342, 42);
            txt_bx_name.Name = "txt_bx_name";
            txt_bx_name.Size = new Size(214, 39);
            txt_bx_name.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 109);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 5;
            label2.Text = "User ID";
            // 
            // FormCreatePlaylist
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 611);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_bx_name);
            Controls.Add(btn_create);
            Controls.Add(txt_bx_userid);
            Controls.Add(checkBox1);
            Name = "FormCreatePlaylist";
            Text = "FormCreatePlaylist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox txt_bx_userid;
        private Button btn_create;
        private TextBox txt_bx_name;
        private Label label1;
        private Label label2;
    }
}