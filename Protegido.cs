using System;

namespace Aula14TryCatch
{
    public class Protegido
    {
        public bool permitir {get; set;}

        public void Autorizar(){
        

            try{

            System.Console.WriteLine("Quer acessar a aplicação? True/False");
            permitir = Boolean.Parse(Console.ReadLine());
            }catch(Exception){
                System.Console.WriteLine("Comando não encontrado!");
            }
            
        }
    }
}