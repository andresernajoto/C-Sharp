string sourcePath = @"D:\.Downloads\Pessoal\Estudos\Programming\C#\Exercícios\StreamWriter\file1.txt";
string targetPath = @"D:\.Downloads\Pessoal\Estudos\Programming\C#\Exercícios\StreamWriter\file2.txt";

try {
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath)) {
        foreach (string line in lines) {
            sw.WriteLine(line.ToUpper());
        }
    }
} catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}