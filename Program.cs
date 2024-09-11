using System.Data;
using System.Globalization;
using textetion_.models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivo/Vendas.json", serializado);

System.Console.WriteLine(serializado);


















// int numero = 20;
// bool ehpar = false;

// // IF ternário

// ehpar  = numero % 2 == 0;

// System.Console.WriteLine($"O número {numero} é  " + (ehpar ? "par"  : "ímpar" ));






// if (numero % 2 == 0)
// {
//     System.Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     System.Console.WriteLine($"O número {numero} é impar");
// }





// Pessoa p1 = new Pessoa("jhenifer", "Camile");

// (string nome, string sobreNome) = p1;

// System.Console.WriteLine($"{nome} {sobreNome}");






// leiaArquivo arquivo = new leiaArquivo();

// var (Sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");

// if (Sucesso)
// {
//     System.Console.WriteLine("Quantidade de linhas do arquivo;" + QuantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         System.Console.WriteLine(linha);
//     }
// }
// else
// {
//     System.Console.WriteLine("Não foi possivel ler o arquivo");
// }











// (int, string, string, decimal) tupla = (17, "lara", "hevely", 1.65M);
// ValueTuple<int, string, string, decimal> outroExemplotuple = (1, "eu", "TU",1.58M);
// var outroExemplotuplaCreate = Tuple.Create(1, "Leonardo", "caio", 1.56M);
 



 
// System.Console.WriteLine($"Id: {tupla.Item1}");
// System.Console.WriteLine($"Nome: {tupla.Item2}");
// System.Console.WriteLine($"Sobrenome: {tupla.Item3}");
// System.Console.WriteLine($"Altura: {tupla.Item4}");










// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//     System.Console.WriteLine(linha);
//     }
// } catch(Exception ex)
// {
//     System.Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }

// System.Console.WriteLine("chegou ate aqui");


















// string dataString = "2024-12-06 14:00";

// bool sucesso =  DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
// CultureInfo.InvariantCulture, DateTimeStyles.None, 
// out DateTime data);

// DateTime data = DateTime.Parse(dataString);

// System.Console.WriteLine(data);


// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

// if(sucesso)
// {
//     System.Console.WriteLine($"Converção com sucesso! Data: {data}");
// }
// else{
//     System.Console.WriteLine($"{dataString} não é uma data válida");
// }
// System.Console.WriteLine(data);


// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// System.Console.WriteLine($"{valorMonetario:C}");

// System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// System.Console.WriteLine(valorMonetario.ToString("C4"));
//                                                 //   N2 
// double porcentagem = .3422;

// System.Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));



// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^



// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;

// System.Console.WriteLine(resultado);

// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


// Pessoa p1 = new Pessoa(nome:"Leonardo", sobreNome:"Bau");
// // p1.Nome = "fred buta";
// // p1.SobreNome = "da Silva";

// Pessoa p2 = new Pessoa(nome:"adelio", sobreNome:"roberto");
// // p2.Nome = "adelio";
// // p2.SobreNome = "roberto";


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

// Pessoa p1 = new Pessoa();
// p1.Nome = "fred buta";
// p1.SobreNome = "da Silva";
// p1.Idade = 45;
// p1.Apresentar();