string path = @"D:\.Downloads\Pessoal\Estudos\Programming\C#\Exercícios\WorkingWithFiles V2.0\file1.txt";

FileStream fs = null;
StreamReader sr = null;

/* PRIMEIRO MÉTODO PARA ABRIR O ARQUIVO E LER UMA LINHA
try {
    // abre o arquivo do caminho desejado
    fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);

    string line = sr.ReadLine();
    Console.WriteLine(line);
} catch (IOException e) {
    Console.WriteLine("An error accurred");
    Console.WriteLine(e.Message);    
} finally {
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}
*/

/* SEGUNDA FORMA PARA ABRIR UM ARQUIVO E LER UMA LINHA
try {
    sr = File.OpenText(path);
    
    string line = sr.ReadLine();
    Console.WriteLine(line);
} catch (IOException e) {
    Console.WriteLine("An error accurred");
    Console.WriteLine(e.Message);
} finally {
    if (sr != null) sr.Close();
}
*/

// MÉTODO PARA ABRIR UM ARQUIVO E LER TODAS SUAS LINHAS
try {
    sr = File.OpenText(path);
    
    while (! sr.EndOfStream) {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
} catch (IOException e) {
    Console.WriteLine("An error accurred");
    Console.WriteLine(e.Message);
} finally {
    if (sr != null) sr.Close();
}
