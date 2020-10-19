namespace Orientação_a_Objetos
{
    public class ContaCorrente
    {
        public Cliente titular;
        private int numeroAgencia;
        public int numero;
        private double saldo;
        private static int TotalDeContas;

        //Construtor
         public ContaCorrente(int numeroAgencia, int numero)
        {
            this.numeroAgencia = numeroAgencia;
            this.numero = numero;
            TotalDeContas++;
        }

        //Metodos
        public bool Sacar (double valor)
        {
            if (this.saldo < valor)
                return false;
            this.saldo -= valor;
            return true;   
        }
        public void Depositar (double valor)
        {
            this.saldo += valor;
        }
        public bool Transferir (double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
                return false;
            else
            {
                this.saldo -= valor;
                destino.Depositar(valor);
                return true;
            } 
        }

        //Getters e Setters
        public double getSaldo()
        {
            return this.saldo;
        }
        public void setSaldo(double saldo)
        {   
            if (this.saldo < 0)
                return;
            this.saldo = saldo;
        }

        public Cliente getTitular()
        {
            return this.titular;
        }
        public void setTitular(Cliente titular)
        {
            this.titular = titular;
        }

        public int getNumeroAgencia()
        {
            return this.numeroAgencia;
        }
        public void setNumeroAgencia(int numeroAgencia)
        {
            if (numeroAgencia <= 0)
                return;
            this.numeroAgencia = numeroAgencia;
        }

        public int getNumero()
        {
            return this.numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public static int getTotalDeContas()
        {
            return TotalDeContas;
        }
    }
}