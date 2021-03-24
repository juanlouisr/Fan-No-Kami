using System;
using System.Collections.Generic;

namespace Fan_No_Kami.Graph {
    class Relation {
        private String name;
        private HashSet<String> friends;

        public Relation(String name) {
            this.name = name;
            this.friends = new HashSet<string>();
        }

        public String getName() {
            return name;
        }

        public HashSet<string> getFriends() {
            return friends;
        }

        public void addFriend(String additionalFriend) {
            this.friends.Add(additionalFriend);
        }

        public String printFriend() {
            string str = this.name + " Mempunyai list teman berikut ->";
            foreach (var setring in friends) {
                str += " " + setring;
            }
            return str;
        }
    }
}
