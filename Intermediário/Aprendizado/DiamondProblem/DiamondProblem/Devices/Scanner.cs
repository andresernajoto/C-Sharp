using System;

namespace DiamondProblem.Devices {
    class Scanner : Device, IScanner {

        // override do método processdoc de device
        public override void ProcessDoc(string document) {
            Console.WriteLine("Scanner processing: " + document);
        }

        // implementação do método scan da interface
        public string Scan() {
            return "Scanner scan result";
        }
    }
}
