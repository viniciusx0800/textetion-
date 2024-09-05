using textetion_.models;

Pessoa p1 = new Pessoa(nome:"Leonardo", sobreNome:"Bau");
// p1.Nome = "fred buta";
// p1.SobreNome = "da Silva";

Pessoa p2 = new Pessoa(nome:"adelio", sobreNome:"roberto");
// p2.Nome = "adelio";
// p2.SobreNome = "roberto";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





























// Pessoa p1 = new Pessoa();
// p1.Nome = "fred buta";
// p1.SobreNome = "da Silva";
// p1.Idade = 45;
// p1.Apresentar();