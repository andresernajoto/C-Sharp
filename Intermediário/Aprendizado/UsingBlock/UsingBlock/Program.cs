string path = @"D:\.Downloads\Pessoal\Estudos\Programming\C#\Exercícios\UsingBlock\file1.txt";

// método resumido de abrir um arquivo e imprimir suas linhas
try {
    using (StreamReader sr = File.OpenText(path)) {
        while (!sr.EndOfStream) {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
