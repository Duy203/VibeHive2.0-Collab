namespace PlaylistBuilder.WinForms
{
    partial class FormRankings
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
            textBox1 = new TextBox();
            btn_load = new Button();
            dgv_ranking = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ranking).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 422);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(652, 422);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(150, 46);
            btn_load.TabIndex = 1;
            btn_load.Text = "Load Ranking";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // dgv_ranking
            // 
            dgv_ranking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ranking.Location = new Point(267, 51);
            dgv_ranking.Name = "dgv_ranking";
            dgv_ranking.RowHeadersWidth = 82;
            dgv_ranking.Size = new Size(778, 300);
            dgv_ranking.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 429);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 3;
            label1.Text = "PlayList ID ";
            // 
            // FormRankings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 630);
            Controls.Add(label1);
            Controls.Add(dgv_ranking);
            Controls.Add(btn_load);
            Controls.Add(textBox1);
            Name = "FormRankings";
            Text = "FormRankings";
            ((System.ComponentModel.ISupportInitialize)dgv_ranking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_load;
        private DataGridView dgv_ranking;
        private Label label1;
    }
}