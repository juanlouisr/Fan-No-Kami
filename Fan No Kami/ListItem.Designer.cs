
namespace Fan_No_Kami {
    partial class ListItem {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_dest = new System.Windows.Forms.Label();
            this.lbl_mutual = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_alur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dest
            // 
            this.lbl_dest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dest.AutoSize = true;
            this.lbl_dest.Font = new System.Drawing.Font("Futura Md BT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dest.Location = new System.Drawing.Point(11, 8);
            this.lbl_dest.Name = "lbl_dest";
            this.lbl_dest.Size = new System.Drawing.Size(43, 42);
            this.lbl_dest.TabIndex = 0;
            this.lbl_dest.Text = "A";
            // 
            // lbl_mutual
            // 
            this.lbl_mutual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_mutual.AutoSize = true;
            this.lbl_mutual.Location = new System.Drawing.Point(65, 15);
            this.lbl_mutual.Name = "lbl_mutual";
            this.lbl_mutual.Size = new System.Drawing.Size(81, 13);
            this.lbl_mutual.TabIndex = 2;
            this.lbl_mutual.Text = "Teman Mutual :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(265, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Telusuri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_alur
            // 
            this.lbl_alur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_alur.AutoSize = true;
            this.lbl_alur.Location = new System.Drawing.Point(65, 31);
            this.lbl_alur.Name = "lbl_alur";
            this.lbl_alur.Size = new System.Drawing.Size(90, 13);
            this.lbl_alur.TabIndex = 4;
            this.lbl_alur.Text = "Cara Terhubung :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_dest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 61);
            this.panel1.TabIndex = 5;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbl_alur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_mutual);
            this.Controls.Add(this.panel1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(360, 61);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dest;
        private System.Windows.Forms.Label lbl_mutual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_alur;
        private System.Windows.Forms.Panel panel1;
    }
}
