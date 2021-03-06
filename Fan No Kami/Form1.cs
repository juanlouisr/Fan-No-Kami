using System;
using Fan_No_Kami.Graph;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl;
using System.IO;

namespace Fan_No_Kami {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btn_start_Click(object sender, EventArgs e) {
            if (!txt_box_namafile.Text.Equals("") || !txt_box_isi_file.Text.Equals("")) {
                if (dfs_opt.Checked || bfs_opt.Checked) {
                    string line;
                    List<string[]> lisString = new List<string[]>();

                    using (StringReader reader = new StringReader(txt_box_isi_file.Text)) {
                        line = reader.ReadLine(); // SKip Line 1
                        while ((line = reader.ReadLine()) != null) {
                            lisString.Add(line.Split(' '));
                        }
                    }
                    //create a graph object 
                    Microsoft.Msagl.Drawing.Graph graph2 = new Microsoft.Msagl.Drawing.Graph("graph");
                    GraphOfRelation g1 = new GraphOfRelation();
                    HashSet<string> listNode = new HashSet<string>();
                    foreach (var str in lisString) {
                        g1.addRelation(str);
                        graph2.AddEdge(str[0],str[1]).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        listNode.Add(str[0]);
                        listNode.Add(str[1]);
                    }
                    foreach (var node in listNode) {
                        Microsoft.Msagl.Drawing.Node temp = graph2.FindNode(node);
                        temp.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                        temp.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aqua;
                    }


                    lbl_isi.Text = g1.printRelation();
                    gViewer1.Graph = graph2;
                }
                else {
                    MessageBox.Show("Anda Belum Memilih Algoritma!");
                }
            } else {
                MessageBox.Show("Anda Belum Memilih File!");
            }
        }

        private void btn_pilih_file_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = openFileDialog1) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            txt_box_namafile.Text = filePath;
            txt_box_isi_file.Text = fileContent;
        }

        private void btn_reset_Click(object sender, EventArgs e) {
            this.Hide();
            Form f1new = new Form1();
            f1new.ShowDialog();
            this.Close();
        }

        private void gViewer1_Load(object sender, EventArgs e) {

        }
    }
}
