using System;
using System.Collections.Generic;
using System.Linq;

namespace Fan_No_Kami.Graph {
    class GraphOfRelation {

        internal enum Algo {
            DFS,
            BFS
        }

        private List<Relation> listOfRelation;

        public GraphOfRelation() {
            this.listOfRelation = new List<Relation>();
        }

        public Dictionary<string, HashSet<string>> kamusTeman() {
            var kmstmn = new Dictionary<string, HashSet<string>>();
            foreach (var r in listOfRelation) {
                kmstmn.Add(r.getName(), r.getFriends());
            }
            return kmstmn;;
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
                str += r.printFriend() + "\n";
            }
            return str;
        }

        // Mereturn string yang berisi mutual friend dari Awal ke Tujuan
        public string printMutualFriends(string awal, string tujuan) {
            var mutualFriend = DFSTemanRekomendasi(awal, tujuan).Item1;
            string str = "Mutual friend :";
            foreach (var friend in mutualFriend) {
                str += " " + friend;
            }
            return str;
        }

        // Menreturn string yang berisi alur dari Awal ke Tujuan (saat ini masih DFS saja)
        public Tuple<string, int> alur(string awal, string tujuan, Algo algo) {

            List<string> alurnya;
            if (algo == Algo.DFS) alurnya = DFS(awal, tujuan);
            else alurnya = BFSAlur(awal, tujuan);
            if (!alurnya.Contains(tujuan)) return Tuple.Create("Tidak Bisa Terhubung ke " + tujuan, 0);
            string str = "Alur menuju " + tujuan + ":";
            foreach (var friend in alurnya) {
                str += " " + friend;
            }
            int degree = alurnya.Count() - 2;
            return Tuple.Create(str,degree);
        }

        
        #endregion
        
        #region BFS Algorithm
        public List<String> BFSAlur(String awal, String tujuan) {
            var qRel = new Queue<string>();
            var seen = new HashSet<string>();
            var flow = new List<string>();
            var kamusTeman = this.kamusTeman();

            //Parent Dictionary

            var parentDictionary = new Dictionary<string, string>();
            qRel.Enqueue(awal);
            while (qRel.Any()) {
                string current = qRel.Dequeue();

                if (!seen.Contains(current)) {
                    seen.Add(current);
                    flow.Add(current);
                }

                foreach (string friends in kamusTeman[current]) {
                    if (!seen.Contains(friends)) {
                        seen.Add(friends);
                        qRel.Enqueue(friends);
                        parentDictionary.Add(friends, current);
                    }

                }
            }
            // END GAME
            var pathFinder = new List<string>();
            string cek = tujuan;
            while (parentDictionary.ContainsKey(cek)) {
                pathFinder.Add(cek);
                cek = parentDictionary[cek];
                if (pathFinder.Contains(awal)) break;
            }
            pathFinder.Add(awal);
            pathFinder.Reverse();
            return pathFinder;
        }

        public List<string> BFS(string awal, string tujuan) {
            var alurTerkunjungi = new List<string>();
            var kamusdata = kamusTeman();
            var seen = new HashSet<string>();
            var queue = new Queue<string>();

            // pengecekan awal apakah ada string atau tidak
            foreach (var r in listOfRelation) {
                if (r.getName().Equals(awal)) {
                    queue.Enqueue(awal);
                    foreach (var nodes in kamusdata[awal]) queue.Enqueue(nodes);
                    break;
                }
            }

            while (queue.Any() && !seen.Contains(tujuan)) {
                var curr = queue.Dequeue();

                if (!seen.Contains(curr)) {
                    seen.Add(curr);
                    alurTerkunjungi.Add(curr);

                }
                foreach (var nodes in kamusdata[curr]) {
                    if (!seen.Contains(nodes)) {
                        queue.Enqueue(nodes);
                    }
                }

            }
            return alurTerkunjungi;
        }
        #endregion

        #region DFS Algorithm
        public Tuple<List<string>, List<string>> DFSTemanRekomendasi(string awal, string tujuan) {
            var alurTerkunjungi = new List<string>();
            var kamusdata = kamusTeman();
            var mutualFriends = new List<string>();
            var stack = new Stack<string>();
            var seen = new HashSet<string>();
            var daftarTeman = new HashSet<string>();

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
                    var temp = kamusdata[curr].ToArray();

                    foreach (var nodes in temp.Reverse().ToArray()) {
                        if (!seen.Contains(nodes)) {
                            stack.Push(nodes);
                        }
                    }
                }
            }

            return Tuple.Create(mutualFriends, alurTerkunjungi);
        }


        public List<String> DFS(String awal, String tujuan) {
            var sRel = new Stack<string>();
            var seen = new List<string>();
            var flow = new List<string>();
            var kamusTeman = this.kamusTeman();

            //Parent Dictionary
            var parentDictionary = new Dictionary<string,string>();

            sRel.Push(awal);
            while (sRel.Any()) {
                var current = sRel.Pop();

                if (!seen.Contains(current)) {
                    seen.Add(current);
                    flow.Add(current);
                }

                if (seen.Contains(tujuan)) {
                    break;
                }
                var temp = kamusTeman[current].ToArray();
               
                foreach (var friends in temp.Reverse().ToArray()) {
                    if (!seen.Contains(friends)) {
                        sRel.Push(friends);
                        if (parentDictionary.ContainsKey(friends)) { parentDictionary[friends] = current; }
                        else { parentDictionary.Add(friends, current); }
                    }
                }
            }
            // END GAME
            // END GAME
            var pathFinder = new List<string>();
            String cek = tujuan;
            while (parentDictionary.ContainsKey(cek)) {
                pathFinder.Add(cek);
                cek = parentDictionary[cek];
                if (pathFinder.Contains(awal)) break;
            }
            pathFinder.Add(awal);
            pathFinder.Reverse() ;
            return pathFinder;
        }


    }
    #endregion


}
