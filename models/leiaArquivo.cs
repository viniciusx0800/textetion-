using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textetion_.models
{
    public class leiaArquivo
    {
        public (bool Sucesso, string[] linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
            string[] linhas = File.ReadAllLines(caminho);

            return (true, linhas, linhas.Count());
            }catch(Exception)
            {
                return (false, new string[0],0);
            }
        }

    }
}