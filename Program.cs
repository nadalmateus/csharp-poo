using System;

namespace csharp_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";
            Console.WriteLine("Hello World");



            var pagamento = new Pagamentos();
            pagamento.Pagar();

            var pagamentoCartaoCredito = new PagamentoCartaoCredito();
            pagamentoCartaoCredito.NumeroCartao = "1234";
        }
    }

    class Pagamentos
    {
        public DateTime Vencimento;


        public virtual void Pagar()
        {

        }

    }
    class PagamentoBoleto : Pagamentos
    {
        public string NumeroBoleto;

        public override void Pagar()
        {
            base.Pagar();
        }
    }

    class PagamentoCartaoCredito : Pagamentos
    {
        public string NumeroCartao { get; set; }

        public override void Pagar() { }

    }

}