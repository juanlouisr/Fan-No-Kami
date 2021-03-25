using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Fan_No_Kami {
    public partial class ListItem : UserControl {
        public ListItem() {
            InitializeComponent();
        }

        #region Properties
        private string _namaNode;
        private string _mutualFriends;
        private string _alur;
        private string _degree;

        [Category("custom props")]
        public string NamaNode {
            get { return _namaNode; }
            set { _namaNode = value; lbl_dest.Text = value; }
        }

        [Category("custom props")]
        public string MutualFriends {
            get { return _mutualFriends; }
            set { _mutualFriends = value; lbl_mutual.Text = value; }
        }

        [Category("custom props")]
        public string Alur {
            get { return _alur; }
            set { _alur = value; lbl_alur.Text = value; }
        }

        [Category("custom props")]
        public string Degree {
            get { return _degree; }
            set { _degree = value; lbl_degree.Text = value; }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e) {
            Form1 form1 = (Form1)ParentForm;
            form1.start(lbl_dest.Text);
        }
    }
}
