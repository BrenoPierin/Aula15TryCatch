using System;

namespace Aula14TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Protegido app = new Protegido();

            app.Autorizar();
            if(app.permitir == true ){

                System.Console.WriteLine("Bem vindo ao sistema de multiplicação! ");
            Contas conta = new Contas();
            conta.operacao();
            }

            System.Console.WriteLine("Você saiu do programa!");
        }
    }
}
