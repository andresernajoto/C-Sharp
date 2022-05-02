using System;
using DiamondProblem.Devices;

namespace DiamondProblem {
    class Program {
        static void Main(string[] args) {

            // instanciação da classe Printer com um serialnumber
            Printer p = new Printer() { SerialNumber = 2601 };
            p.ProcessDoc("My letter");
            p.Print("My letter");
            Console.WriteLine();

            // instanciação da classe Scanner com um serialnumber
            Scanner s = new Scanner() { SerialNumber = 0401 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());
            Console.WriteLine();

            // instanciação da classe Combodevice com um serialnumber
            ComboDevice c = new ComboDevice { SerialNumber = 1401 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
