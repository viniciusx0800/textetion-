using System.Globalization;
using textetion_.models;
// using System.Globalization;

 CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

System.Console.WriteLine($"{valorMonetario:C}");

// System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
System.Console.WriteLine(valorMonetario.ToString("C4"));
                                                //   N2 


















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