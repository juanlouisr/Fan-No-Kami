using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan_No_Kami.Graph {
    class GraphOfRelation {
        private List<Relation> listOfRelation;
        
        public GraphOfRelation() {
            this.listOfRelation = new List<Relation>();
        }

        public Dictionary<string, List<string>> kamusTeman() {
            var kmstmn = new Dictionary<string, List<string>>();
            foreach (var r in listOfRelation) {
                kmstmn.Add(r.getName(), r.getFriends());
            }
            return kmstmn;
        }
        
        public void addRelation(String[] s) {
            // Komponen kiri pada input
            if (listOfRelation.Count() > 0) {
                int add_0 = 0;
                int add_1 = 0;
                foreach (Relation r in listOfRelation) {
                    if (r.getName().Equals(s[0])) {
                        r.addFriend(s[1]);
                        add_0++;
                    }
                }
                // Kalo gaada komponen kiri, buat relasi baru
                if (add_0 < 1) {
                    Relation rNewInput_0 = new Relation(s[0]);
                    rNewInput_0.addFriend(s[1]);
                    listOfRelation.Add(rNewInput_0);
                }
                // Komponen kanan
                foreach (Relation r in listOfRelation) {
                    if (r.getName().Equals(s[1])) {
                        r.addFriend(s[0]);
                        add_1++;
                    }
                }
                // Kalo gaada komponen kanan
                if (add_1 < 1) {
                    Relation rNewInput_1 = new Relation(s[1]);
                    rNewInput_1.addFriend(s[0]);
                    listOfRelation.Add(rNewInput_1);
                }
            }
            else {
                Relation rNewInput_0 = new Relation(s[0]);
                Relation rNewInput_1 = new Relation(s[1]);
                rNewInput_0.addFriend(s[1]);
                rNewInput_1.addFriend(s[0]);
                listOfRelation.Add(rNewInput_0);
                listOfRelation.Add(rNewInput_1);
            }
        }

        #region Print Method

        // Mereturn string yang berisi Node : Teman-Temannya (adjacentNode)
        public string printRelation() {
            string str = "";
            foreach (Relation r in listOfRelation) {
                str += r.printFriend() +"\n";
            }
            return str;
        }

        // Mereturn string yang berisi mutual friend dari Awal ke Tujuan
        public string printMutualFriends(string awal, string tujuan) {
            var mutualFriend = DFSTemanRekomendasi(awal, tujuan).Item1;
            string str = "Mutual friend :";
            foreach (var friend in mutualFriend) {
                str += " "+ friend ;
            }
            return str;
        }
        
        // Menreturn string yang berisi alur dari Awal ke Tujuan (saat ini masih DFS saja)
        public string alur(string awal, string tujuan) {
            var mutualFriend = DFSTemanRekomendasi(awal, tujuan).Item2;
            if (!mutualFriend.Contains(tujuan)) return "Tidak Bisa Terhubung ke " + tujuan;
            string str = "Alur menuju " + tujuan + ":";
            foreach (var friend in mutualFriend) {
                str += " " + friend;
            }
            return str;
        }

        #endregion

        #region DFS Algorithm
        public Tuple<List<string>, List<string>>  DFSTemanRekomendasi(string awal,string tujuan) {
            var alurTerkunjungi = new List<string>();
            var kamusdata = kamusTeman();
            var mutualFriends = new List<string>();
            var stack = new Stack<string>();
            var seen = new HashSet<string>();
            var daftarTeman = new List<string>();

            // pengecekan awal apakah ada string atau tidak
            foreach (var r in listOfRelation) {
                if (r.getName().Equals(awal)) {
                    stack.Push(awal);
                    daftarTeman = r.getFriends();
                    break;
                }
            }

            //daftarTeman = kamusdata[awal];

            while (stack.Any() && !seen.Contains(tujuan)) {
                string curr = stack.Pop();

                if (!seen.Contains(curr)) {
                    seen.Add(curr);
                    alurTerkunjungi.Add(curr);

                    if (curr.Equals(tujuan)) {

                        foreach (var namateman in kamusdata[curr]) {
                            if (daftarTeman.Contains(namateman)) {
                                mutualFriends.Add(namateman);
                            }
                        }
                    }

                    foreach (var nodes in kamusdata[curr]) {
                        if (!seen.Contains(nodes)) {
                            stack.Push(nodes);
                        }
                    }
                }
            }

            return Tuple.Create(mutualFriends,alurTerkunjungi);
        }

    }
    #endregion

        
}
