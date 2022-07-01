namespace OOP
{
    public class CafeteiraEspressa : Eletrododomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem) { }

        public CafeteiraEspressa() : base("Padrão", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepagarCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            TestarNoamente();
            // ETC
        }

        // Não é possível sobrescrever, pois não é abstract e nem virtual
        //public override Testar() { }

        // Posso sobrescrever por ser virtual
        public override void TestarNoamente()
        {
            // Teste de café
        }

        // Sou obrigado a sobrescrever por ser abstract
        public override void Ligar()
        {
            //throw new System.NotImplementedException();
        }


        // Sou obrigado a sobrescrever por ser abstract
        public override void Desligar()
        {
            //throw new System.NotImplementedException();
        }
    }
}
