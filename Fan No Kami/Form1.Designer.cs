
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
            this.lbl_relasi = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_isi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(1, 9);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(280, 73);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "団扇の神";
            // 
            // lbl_relasi
            // 
            this.lbl_relasi.AutoSize = true;
            this.lbl_relasi.Location = new System.Drawing.Point(60, 159);
            this.lbl_relasi.Name = "lbl_relasi";
            this.lbl_relasi.Size = new System.Drawing.Size(93, 13);
            this.lbl_relasi.TabIndex = 1;
            this.lbl_relasi.Text = "string place holder";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(63, 110);
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
            this.lbl_isi.Location = new System.Drawing.Point(219, 159);
            this.lbl_isi.Name = "lbl_isi";
            this.lbl_isi.Size = new System.Drawing.Size(41, 13);
            this.lbl_isi.TabIndex = 3;
            this.lbl_isi.Text = "test lah";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_isi);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_relasi);
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
        private System.Windows.Forms.Label lbl_relasi;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_isi;
    }
}

