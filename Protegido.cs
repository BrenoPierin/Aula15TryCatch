using System;

namespace Aula14TryCatch
{
    public class Protegido
    {
        public Protegido(bool permitir) 
        {
            this.permitir = permitir;
               
        }
                private bool permitir {get; set;}

        public void Autorizar(){
            
            do{

            try{

            System.Console.WriteLine("Quer acessar a aplicação? True/False");
            permitir = Boolean.Parse(Console.ReadLine());
            }catch(Exception){
                System.Console.WriteLine("Comando não encontrado!");
            }
            }while(permitir){
               permitir = true && false;
            }
        }
    }
}