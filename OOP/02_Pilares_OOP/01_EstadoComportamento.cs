using System;

namespace OOP
{
    public class Pessoa
    {

        // Estado
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }


        // Comportamento - Pode gerar um valor ou alterar um estado da classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade; // Gerado a partir de um comportamento
        }
    }
}
