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
using System.Threading;
using System.IO;

namespace Fan_No_Kami {
    public partial class Form1 : Form {

        GraphOfRelation g1;
        HashSet<string> listNode;

        public Form1() {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) {

        }

        // Saat tombol "mulai" di klik
        public void btn_start_Click(object sender, EventArgs e) {
            if (!txt_box_namafile.Text.Equals("") || !txt_box_isi_file.Text.Equals("")) {
                try {
                    if (dfs_opt.Checked || bfs_opt.Checked) {
                        if (dfs_opt.Checked) {
                            flowLayoutPanel1.Controls.Clear();
                            populateItem();
                            traverseGraph(gViewer1.Graph, g1.DFSTemanRekomendasi(txtbox_src.Text, txtbox_dest.Text).Item2);
                        }
                        else {
                            MessageBox.Show("Algoritma belum selesai");
                        }
                    }
                    else {
                        MessageBox.Show("Anda Belum Memilih Algoritma!");
                    }
                }
                catch (IndexOutOfRangeException) {
                    MessageBox.Show("Error! Tidak ada Node yang bernama " + txtbox_src.Text);
                }
            } else {
                MessageBox.Show("Anda Belum Memilih File!");
            }
        }

        // Menganimasikan Jalannnya graph
        private void traverseGraph(Microsoft.Msagl.Drawing.Graph graph2, List<string> dafftarNode) {
            foreach (var node in dafftarNode) {
                graph2.FindNode(node).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                gViewer1.Graph = graph2;
                this.Refresh();
                Thread.Sleep(1000);
                
                graph2.FindNode(node).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aqua;
                gViewer1.Graph = graph2;

            }
        }

        // Menload file dan menampilkan visualiasi graph
        public void btn_pilih_file_Click(object sender, EventArgs e) {
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

            // Udapte file content
            txt_box_namafile.Text = filePath;
            txt_box_isi_file.Text = fileContent;

            visualizeGraph();
        }

        // Mengload ulang visualisasi graph
        private void btn_refresh_Click(object sender, EventArgs e) {
            visualizeGraph();
        }

        // Menload ulang form
        private void btn_reset_Click(object sender, EventArgs e) {
            this.Hide();
            Form f1new = new Form1();
            f1new.ShowDialog();
            this.Close();
        }

        private void gViewer1_Load(object sender, EventArgs e) {

        }

        // Membuat List Item (referensi user control :  ListItem.cs ) saat ini masih DFS saja
        private void populateItem() {
            ListItem[] listItems = new ListItem[listNode.Count-1];
            int i = 0;
            foreach (var node in listNode) {
                if (!node.Equals(txtbox_src.Text)) {
                    listItems[i] = new ListItem();
                    listItems[i].NamaNode = node;
                    listItems[i].MutualFriends = g1.printMutualFriends(txtbox_src.Text, node);
                    listItems[i].Alur = g1.alur(txtbox_src.Text, node);
                    if (flowLayoutPanel1.Controls.Count < 0) {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else {
                        flowLayoutPanel1.Controls.Add(listItems[i]);
                    }
                    i++;
                }
 
            }
        }

        // Menampilkan visualisasi graph pada gviewer MSAGL
        private void visualizeGraph() {
            g1 = new GraphOfRelation();
            listNode = new HashSet<string>();
            // Algoritma Membaca Text File
            string line;
            List<string[]> lisString = new List<string[]>();
            using (StringReader reader = new StringReader(txt_box_isi_file.Text)) {
                line = reader.ReadLine(); // SKip Line 1
                while ((line = reader.ReadLine()) != null) {
                    if (!line.Equals("")) {
                        lisString.Add(line.Split(' '));
                    }
                }
            }
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph2 = new Microsoft.Msagl.Drawing.Graph("graph");

            // Mengassign Graph dari Text (lisString)
            foreach (var str in lisString) {
                g1.addRelation(str);
                graph2.AddEdge(str[0], str[1]).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                listNode.Add(str[0]);
                listNode.Add(str[1]);
            }

            // Mengubah design visualiasi graph
            foreach (var node in listNode) {
                Microsoft.Msagl.Drawing.Node temp = graph2.FindNode(node);
                temp.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                temp.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aqua;
            }


            // Menampilkan Graph MSAGL
            gViewer1.Graph = graph2;
        }
    
    }
}
