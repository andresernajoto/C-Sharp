using System;
using System.Collections.Generic;
using System.Text;

namespace HashCollectionsEquality.Entities {
    struct Point {

        // atributos do struct
        public int X { get; set; }
        public int Y { get; set; }

        // construtor recebendo os atributos
        public Point(int x, int y) : this() {
            X = x;
            Y = y;
        }
    }
}
