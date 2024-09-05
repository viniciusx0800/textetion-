using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textetion_.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno ( Pessoa aluno )
        {
            Alunos.Add (aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            System.Console.WriteLine($"Alunos do curso de:{Nome}");
            foreach(Pessoa aluno in Alunos)
            {
                System.Console.WriteLine(aluno.NomeCompleto);
            }
            
        }
    }
}