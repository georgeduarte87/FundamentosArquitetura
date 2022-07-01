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


        // Como Abstrato, Não permite implementar, mas obriga a sobrescrever
        public abstract void Ligar();
        public abstract void Desligar();

        // Sem Abstract - Te obriga a implementar, mas não permite sobrescrever
        public void Testar()
        {
            // Fazer teste do equipamento
        }

        // Ser abstract, mas com Virtual - Não te obriga a sobrescrever, mas precisa implementar
        public virtual void TestarNoamente()
        {
            // Fazer teste do equipamento
        }
    }
}
