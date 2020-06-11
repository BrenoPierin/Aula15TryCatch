using System;

namespace Aula14TryCatch
{
    public class Contas
    {
        public int num1 { get; set; }

        public int num2 { get; set; }

        public void operacao(){
           
           try{

            System.Console.WriteLine("digite um numero:");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite outro numero:");
            num2 = int.Parse(Console.ReadLine());
            
            int resultado = num1*num2; 
            System.Console.WriteLine(resultado);
           }catch(Exception){
               System.Console.WriteLine("Erro, o valor só pode ser um numero");
           }
        }
    }
}