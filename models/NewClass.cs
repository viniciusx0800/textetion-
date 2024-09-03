using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textetion_.models
{
    public class NewClass
    {
        private string _nome;
        public string Nome 
        {
          get{
            return _nome.ToUpper();
          }
         
          set{
            if (value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }

            _nome = value
          } 

       }
        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($"nome: {Nome}, idade: {Idade}");

        }
    }
}