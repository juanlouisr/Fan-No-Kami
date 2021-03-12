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
        string fileContent = string.Empty;

        public Form1() {
            InitializeComponent();
        }

        // Ketika Form di munculkan
        private void Form1_Load(object sender, EventArgs e) {
            txt_box_namafile.Text = "";
            lbl_rcmded.Text = "";
        }

        // Saat tombol "mulai" di klik
        private void btn_start_Click(object sender, EventArgs e) {
            start("");
        }
    
        // Menjalankan animasi
        internal void start(string tujuan) {
            if (!txt_box_namafile.Text.Equals("") || !txt_box_isi_file.Text.Equals("")) {
                try {
                    if (dfs_opt.Checked || bfs_opt.Checked) {
                        if (comboBox1.Text.Equals("")) throw new IndexOutOfRangeException();
                        flowLayoutPanel1.Controls.Clear();
                        populateItem(comboBox1.Text);
                        if (dfs_opt.Checked) {
                            traverseGraph(gViewer1.Graph, g1.DFSTemanRekomendasi(comboBox1.Text, tujuan).Item2);
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
                    MessageBox.Show("Error! Node awal belum dipilih");
                }
            }
            else {
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
                
                graph2.FindNode(node).Attr.FillColor = Microsoft.Msagl.Drawing.Color.SteelBlue;
                gViewer1.Graph = graph2;

            }
        }

        // Menload file dan menampilkan visualiasi graph
        public void btn_pilih_file_Click(object sender, EventArgs e) {
            
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
                    // Udapte file content
                    txt_box_namafile.Text = filePath;
                    txt_box_isi_file.Text = fileContent;

                    visualizeGraph();
                }
            }
        }

        // Mengload ulang visualisasi graph
        private void btn_refresh_Click(object sender, EventArgs e) {
            visualizeGraph();
        }

        // Menload ulang graph semula
        private void btn_reset_Click(object sender, EventArgs e) {
            //this.Hide();
            //Form f1new = new Form1();
            //f1new.ShowDialog();
            //this.Close();
            txt_box_isi_file.Text = fileContent;
            if (!txt_box_isi_file.Text.Equals("")) visualizeGraph();
        }

        // Membuat List Item (referensi user control :  ListItem.cs ) saat ini masih DFS saja
        private void populateItem(string awal) {
            ListItem[] listItems = new ListItem[listNode.Count-1];
            int i = 0;
            foreach (var node in listNode) {
                if (!node.Equals(awal)) {
                    listItems[i] = new ListItem();
                    listItems[i].NamaNode = node;
                    listItems[i].MutualFriends = g1.printMutualFriends(awal, node);
                    listItems[i].Alur = g1.alur(awal, node, GraphOfRelation.Algo.DFS);
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
                if (!comboBox1.Items.Contains(node)) comboBox1.Items.Add(node);
                Microsoft.Msagl.Drawing.Node temp = graph2.FindNode(node);
                temp.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                temp.Attr.FillColor = Microsoft.Msagl.Drawing.Color.SteelBlue;
                temp.Label.FontColor = Microsoft.Msagl.Drawing.Color.White;
            }
            string tesmsdas = comboBox1.Text;

            // Menampilkan Graph MSAGL
            gViewer1.Graph = graph2;
        }

        // Menampilkan list item saat node awal dipilih
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
            try {
                if (dfs_opt.Checked || bfs_opt.Checked) {
                    lbl_rcmded.Text = "Rekomendasi Teman:";
                    if (dfs_opt.Checked) {
                        flowLayoutPanel1.Controls.Clear();
                        populateItem(comboBox1.Text);

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
                MessageBox.Show("Error! Tidak ada Node yang bernama " + comboBox1.Text);
            }

        }
    }
}
