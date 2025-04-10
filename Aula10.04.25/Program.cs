using static System.Console;


string[] nomes = { "Pedro", "Cachorro", "Gato", "Lino", "Gabriel" };

string novonome = "";
WriteLine("Insira um nome a mais: ");
novonome = Convert.ToString(ReadLine());
List<string> novosnomes = new List<string>(nomes.ToList());
novosnomes.Add(novonome);
nomes = novosnomes.ToArray();
Array.Sort(nomes);

foreach (var item in nomes)
{
    WriteLine($"\nNome adicionado: {item}");
}
ReadLine();

