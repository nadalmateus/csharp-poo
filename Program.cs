using System;

namespace csharp_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentos = new Pagamentos();
            Console.WriteLine("Hello World");

        }
    }

    public class Pagamentos
    {
        protected DateTime Vencimento;

        void Pagar()
        {

        }
    }
    public class PagamentosBoleto : Pagamentos
    {


        void Teste()
        {
            base.Pagar();

        }
    }

}