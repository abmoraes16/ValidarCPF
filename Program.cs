using System;

namespace ValidarCPF
{
    class Program
    {
        static int[] multiplicador = {10,9,8,7,6,5,4,3,2};
        static int[] multiplicador2 = {11,10,9,8,7,6,5,4,3,2};
        static string cpf;
        static string tempCpf;
        static int soma = 0, resto = 0;

        static string primeiroDigito, segundoDigito;

        static void Main(string[] args)
        {
            Console.WriteLine("_____VALIDACAO DE DOCUMENTOS_____");

            do{
                Console.Write("Digite seu CPF: ");
                cpf = Console.ReadLine();
            }while(cpf.Length!=11);

            primeiroDigito = CalculaPrimeiroDigito();
            
            if(primeiroDigito!=cpf.Substring(9,1)){
                Console.WriteLine("CPF inválido!");
            }
            else
            {

            segundoDigito = CalculaSegundoDigito();
            //segundoDigito
                if (cpf.EndsWith(segundoDigito)==true){
                    Console.WriteLine("CPF válido!");
                }
                else{
                    Console.WriteLine("CPF inválido!"); 
                }
            }

        }

        static String CalculaPrimeiroDigito(){
           soma = 0;
           resto = 0;
            
            //Console.WriteLine(cpf);
            tempCpf = cpf.Substring(0,9);

            //Console.WriteLine("Soma: "+soma);
            //Console.WriteLine("tempCpf: "+tempCpf);

            for(int i=0;i<9;i++){
                //Console.WriteLine(tempCpf[i]+" * "+ multiplicador[i]+"="+Convert.ToInt16(tempCpf[i].ToString())*multiplicador[i]);
                soma += Convert.ToInt16(tempCpf[i].ToString())*multiplicador[i];

                //Console.WriteLine("Soma: "+soma);
            }
            //Console.WriteLine("Soma: "+soma);
            resto = soma % 11;

            //Console.WriteLine("Resto: "+resto);

            if(resto<2){
                return "0";        
            }
            else
            {
                return (11-resto).ToString();
            }            
        
        }

        static String CalculaSegundoDigito(){
           tempCpf = cpf.Substring(0,10);
           soma = 0;
           resto = 0;

            //Console.WriteLine("Soma: "+soma);
            //Console.WriteLine("tempCpf: "+tempCpf);

            for(int i=0;i<10;i++){
                //Console.WriteLine(tempCpf[i]+" * "+ multiplicador2[i]+"="+Convert.ToInt16(tempCpf[i].ToString())*multiplicador2[i]);
                soma += Convert.ToInt16(tempCpf[i].ToString())*multiplicador2[i];

                //Console.WriteLine("Soma: "+soma);
            }
            //Console.WriteLine("Soma: "+soma);
            resto = soma % 11;

            //Console.WriteLine("Resto: "+resto);

            if(resto<2){
                return "0";        
            }
            else
            {
                return (11-resto).ToString();
            }                    
        }



    }
}
