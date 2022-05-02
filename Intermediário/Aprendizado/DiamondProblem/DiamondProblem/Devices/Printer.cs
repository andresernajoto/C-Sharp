using System;

namespace DiamondProblem.Devices { 
    class Printer : Device, IPrinter {

        // override do método ProcessDoc do Device
        public override void ProcessDoc(string document) {
            Console.WriteLine("Printer processing: " + document);
        }

        // implementação do método print da interface
        public void Print(string document) {
            Console.WriteLine("Printer print " + document);
        }
    }
}
