// busca o caminho do arquivo já existente
string sourcePath = @"D:\.Downloads\Pessoal\Estudos\Programming\C#\Exercícios\WorkingWithFiles\file1.txt";
// mostra o caminho e o nome do arquivo a ser escolhido
string targetPath = @"D:\.Downloads\Pessoal\Estudos\Programming\C#\Exercícios\WorkingWithFiles\file2.txt";

/* o bloco abaixo tentará copiar o conteúdo
 do arquivo 1 para o 2, imprimindo no console
o seu conteúdo, caso o arquivo não exista */
try {
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines) {
        Console.WriteLine(line);
    }
}
catch (IOException e) {
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}