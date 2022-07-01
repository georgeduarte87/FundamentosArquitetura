namespace OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {

            // Por estar encapsulado, ninguém conhece os métodos envolvidos
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepagarCafe();
            espresso.Desligar();

        }
    }
}
