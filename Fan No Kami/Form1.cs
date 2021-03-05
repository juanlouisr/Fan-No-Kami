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
using System.IO;

namespace Fan_No_Kami {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btn_start_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
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
            string line;
            List<string[]> lisString = new List<string[]>();

            using (StringReader reader = new StringReader(fileContent)) {
                line = reader.ReadLine(); // SKip Line 1
                while ((line = reader.ReadLine()) != null) {
                    lisString.Add(line.Split(' '));
                }
            }

            GraphOfRelation g1 = new GraphOfRelation();
            foreach (var str in lisString) {
                g1.addRelation(str);
            }
            lbl_isi.Text = g1.printRelation();
            lbl_relasi.Text = fileContent;
        }
    }
}
