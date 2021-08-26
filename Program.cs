using System;

namespace csharp_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

    class Pagamentos
    {
        DateTime Vencimento;


        void Pagar()
        {
            ConsultarSaldoDoCartao("123123123");

        }

        private void ConsultarSaldoDoCartao(string numerocartao)
        {

        }
    }

}