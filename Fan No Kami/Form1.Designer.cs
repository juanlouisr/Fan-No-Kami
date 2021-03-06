
namespace Fan_No_Kami {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_logo = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_isi = new System.Windows.Forms.Label();
            this.txt_box_isi_file = new System.Windows.Forms.RichTextBox();
            this.dfs_opt = new System.Windows.Forms.RadioButton();
            this.bfs_opt = new System.Windows.Forms.RadioButton();
            this.btn_pilih_file = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_box_namafile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(1, 11);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(280, 73);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "団扇の神";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(252, 155);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "mulai";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_isi
            // 
            this.lbl_isi.AutoSize = true;
            this.lbl_isi.Location = new System.Drawing.Point(239, 194);
            this.lbl_isi.Name = "lbl_isi";
            this.lbl_isi.Size = new System.Drawing.Size(31, 13);
            this.lbl_isi.TabIndex = 3;
            this.lbl_isi.Text = "relasi";
            // 
            // txt_box_isi_file
            // 
            this.txt_box_isi_file.Location = new System.Drawing.Point(32, 178);
            this.txt_box_isi_file.Name = "txt_box_isi_file";
            this.txt_box_isi_file.ReadOnly = true;
            this.txt_box_isi_file.Size = new System.Drawing.Size(95, 205);
            this.txt_box_isi_file.TabIndex = 4;
            this.txt_box_isi_file.Text = "";
            // 
            // dfs_opt
            // 
            this.dfs_opt.AutoSize = true;
            this.dfs_opt.Location = new System.Drawing.Point(252, 109);
            this.dfs_opt.Name = "dfs_opt";
            this.dfs_opt.Size = new System.Drawing.Size(46, 17);
            this.dfs_opt.TabIndex = 5;
            this.dfs_opt.TabStop = true;
            this.dfs_opt.Text = "DFS";
            this.dfs_opt.UseVisualStyleBackColor = true;
            // 
            // bfs_opt
            // 
            this.bfs_opt.AutoSize = true;
            this.bfs_opt.Location = new System.Drawing.Point(252, 132);
            this.bfs_opt.Name = "bfs_opt";
            this.bfs_opt.Size = new System.Drawing.Size(45, 17);
            this.bfs_opt.TabIndex = 6;
            this.bfs_opt.TabStop = true;
            this.bfs_opt.Text = "BFS";
            this.bfs_opt.UseVisualStyleBackColor = true;
            // 
            // btn_pilih_file
            // 
            this.btn_pilih_file.Location = new System.Drawing.Point(142, 112);
            this.btn_pilih_file.Name = "btn_pilih_file";
            this.btn_pilih_file.Size = new System.Drawing.Size(75, 23);
            this.btn_pilih_file.TabIndex = 7;
            this.btn_pilih_file.Text = "Pilih File";
            this.btn_pilih_file.UseVisualStyleBackColor = true;
            this.btn_pilih_file.Click += new System.EventHandler(this.btn_pilih_file_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(32, 401);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_box_namafile
            // 
            this.txt_box_namafile.BackColor = System.Drawing.SystemColors.Control;
            this.txt_box_namafile.Location = new System.Drawing.Point(32, 114);
            this.txt_box_namafile.Multiline = false;
            this.txt_box_namafile.Name = "txt_box_namafile";
            this.txt_box_namafile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txt_box_namafile.Size = new System.Drawing.Size(95, 19);
            this.txt_box_namafile.TabIndex = 9;
            this.txt_box_namafile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.txt_box_namafile);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_pilih_file);
            this.Controls.Add(this.bfs_opt);
            this.Controls.Add(this.dfs_opt);
            this.Controls.Add(this.txt_box_isi_file);
            this.Controls.Add(this.lbl_isi);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_logo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_isi;
        private System.Windows.Forms.RichTextBox txt_box_isi_file;
        private System.Windows.Forms.RadioButton dfs_opt;
        private System.Windows.Forms.RadioButton bfs_opt;
        private System.Windows.Forms.Button btn_pilih_file;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.RichTextBox txt_box_namafile;
    }
}

