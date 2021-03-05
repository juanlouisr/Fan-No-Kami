using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan_No_Kami.Graph {
    class GraphOfRelation {
        private List<Relation> listOfRelation;
        private List<String> setOfNama;

        public GraphOfRelation() {
            this.listOfRelation = new List<Relation>();
            this.setOfNama = new List<String>();
        }
        public int getNumberOfVertex() => setOfNama.Count();
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
        public String printRelation() {
            String str = "";
            foreach (Relation r in listOfRelation) {
                str += r.printFriend() +"\n";
            }
            return str;
        }
    }
}
