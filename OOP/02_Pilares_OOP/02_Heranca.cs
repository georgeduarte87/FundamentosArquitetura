using System;

namespace OOP
{
    // Herança - Ocorre sempre que algo é outra coisa - Um funcionário é uma pessoa - Herda do mais universal no contexto
    public class Funcionario : Pessoa 
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            // Quando há herança, as atribuições ocorrem de forma natural
            var funcionario = new Funcionario()
            {
                Nome = "João das Couve",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456"
            };
        }
    }
}
