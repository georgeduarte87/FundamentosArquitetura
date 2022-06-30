namespace OOP
{
    // Abstrair uma especialização - Conceito de super classe sem forçar implementação
    // Uma classe abestrata só pode ser herdada e nunca instanciada
    public abstract class Eletrododomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrododomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }


        // Como Abstrato, não fica obrigatório implementar
        public abstract void Ligar();
        public abstract void Desligar();
    }
}
