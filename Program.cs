using System;

namespace csharp_poo
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando o pagamento");
            }



        }
    }

    public class Pagamento : IDisposable
    {

        public Pagamento()
        {
            Console.WriteLine("Iniciando Pagamento");

        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando Pagamento");
        }
    }


}