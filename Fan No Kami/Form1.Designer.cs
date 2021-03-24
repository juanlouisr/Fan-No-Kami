
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_box_isi_file = new System.Windows.Forms.RichTextBox();
            this.dfs_opt = new System.Windows.Forms.RadioButton();
            this.bfs_opt = new System.Windows.Forms.RadioButton();
            this.btn_pilih_file = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_box_namafile = new System.Windows.Forms.Label();
            this.lbl_rcmded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.lbl_logo.Location = new System.Drawing.Point(12, 26);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(310, 80);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "団扇の神";
            // 
            // btn_start
            // 
            this.btn_start.AutoSize = true;
            this.btn_start.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F);
            this.btn_start.Location = new System.Drawing.Point(403, 150);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(103, 25);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "mulai";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_box_isi_file
            // 
            this.txt_box_isi_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_box_isi_file.BackColor = System.Drawing.Color.White;
            this.txt_box_isi_file.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_isi_file.Location = new System.Drawing.Point(26, 178);
            this.txt_box_isi_file.Name = "txt_box_isi_file";
            this.txt_box_isi_file.Size = new System.Drawing.Size(81, 357);
            this.txt_box_isi_file.TabIndex = 4;
            this.txt_box_isi_file.Text = "";
            // 
            // dfs_opt
            // 
            this.dfs_opt.AutoSize = true;
            this.dfs_opt.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold);
            this.dfs_opt.ForeColor = System.Drawing.Color.White;
            this.dfs_opt.Location = new System.Drawing.Point(403, 131);
            this.dfs_opt.Name = "dfs_opt";
            this.dfs_opt.Size = new System.Drawing.Size(49, 17);
            this.dfs_opt.TabIndex = 5;
            this.dfs_opt.TabStop = true;
            this.dfs_opt.Text = "DFS";
            this.dfs_opt.UseVisualStyleBackColor = true;
            // 
            // bfs_opt
            // 
            this.bfs_opt.AutoSize = true;
            this.bfs_opt.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfs_opt.ForeColor = System.Drawing.Color.White;
            this.bfs_opt.Location = new System.Drawing.Point(458, 131);
            this.bfs_opt.Name = "bfs_opt";
            this.bfs_opt.Size = new System.Drawing.Size(48, 17);
            this.bfs_opt.TabIndex = 6;
            this.bfs_opt.TabStop = true;
            this.bfs_opt.Text = "BFS";
            this.bfs_opt.UseVisualStyleBackColor = true;
            // 
            // btn_pilih_file
            // 
            this.btn_pilih_file.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_pilih_file.Location = new System.Drawing.Point(26, 132);
            this.btn_pilih_file.Name = "btn_pilih_file";
            this.btn_pilih_file.Size = new System.Drawing.Size(82, 26);
            this.btn_pilih_file.TabIndex = 7;
            this.btn_pilih_file.Text = "Pilih File";
            this.btn_pilih_file.UseVisualStyleBackColor = true;
            this.btn_pilih_file.Click += new System.EventHandler(this.btn_pilih_file_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.AutoSize = true;
            this.btn_reset.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F);
            this.btn_reset.Location = new System.Drawing.Point(26, 577);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(81, 25);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = false;
            this.gViewer1.FileName = "";
            this.gViewer1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = false;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(548, 30);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = false;
            this.gViewer1.SaveAsMsaglEnabled = false;
            this.gViewer1.SaveButtonVisible = false;
            this.gViewer1.SaveGraphButtonVisible = false;
            this.gViewer1.SaveInVectorFormatEnabled = false;
            this.gViewer1.Size = new System.Drawing.Size(306, 572);
            this.gViewer1.TabIndex = 10;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = false;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = false;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Asal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(169)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(134, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 421);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.AutoSize = true;
            this.btn_refresh.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_refresh.Location = new System.Drawing.Point(26, 548);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(81, 25);
            this.btn_refresh.TabIndex = 20;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 23);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_box_namafile
            // 
            this.txt_box_namafile.AutoSize = true;
            this.txt_box_namafile.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.txt_box_namafile.ForeColor = System.Drawing.Color.White;
            this.txt_box_namafile.Location = new System.Drawing.Point(21, 106);
            this.txt_box_namafile.Name = "txt_box_namafile";
            this.txt_box_namafile.Size = new System.Drawing.Size(87, 28);
            this.txt_box_namafile.TabIndex = 22;
            this.txt_box_namafile.Text = "nama file";
            // 
            // lbl_rcmded
            // 
            this.lbl_rcmded.AutoSize = true;
            this.lbl_rcmded.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_rcmded.ForeColor = System.Drawing.Color.White;
            this.lbl_rcmded.Location = new System.Drawing.Point(132, 152);
            this.lbl_rcmded.Name = "lbl_rcmded";
            this.lbl_rcmded.Size = new System.Drawing.Size(183, 28);
            this.lbl_rcmded.TabIndex = 23;
            this.lbl_rcmded.Text = "Rekomendasi Teman:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(884, 632);
            this.Controls.Add(this.lbl_rcmded);
            this.Controls.Add(this.txt_box_namafile);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_pilih_file);
            this.Controls.Add(this.bfs_opt);
            this.Controls.Add(this.dfs_opt);
            this.Controls.Add(this.txt_box_isi_file);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 671);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kipasu No Kami";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txt_box_isi_file;
        private System.Windows.Forms.RadioButton dfs_opt;
        private System.Windows.Forms.RadioButton bfs_opt;
        private System.Windows.Forms.Button btn_pilih_file;
        private System.Windows.Forms.Button btn_reset;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label txt_box_namafile;
        internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_rcmded;
    }
}

