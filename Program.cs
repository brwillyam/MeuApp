using System;
using System.Threading;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args){
            BoasVindas();
        }
        static void BoasVindas(){
            Console.Clear();
            Console.WriteLine("Bem vindo ao MeuApp!!!");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Vc deve estar se perguntando oq isso faz?");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Basicamente vamos interagir um pouco, sera divertido!");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Bom vamos ao menu");
            Thread.Sleep(2500);
            Console.Clear();

            Menu();

        }
        static void Menu(){
            Console.Clear();

            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Quizz ");
            Console.WriteLine("2 - verdadeiro ou falso");
            Console.WriteLine("3 - um pouco de numeros");
            Console.WriteLine("0 - sair");

            byte opcao = byte.Parse(Console.ReadLine());
            if(opcao == 1)
            Quizz();
            if(opcao == 2)
            VerdadeiroOuFalso();
            if(opcao == 3)
            Numeros();
            if(opcao == 0)
            System.Environment.Exit(0);


        }
        static void Quizz(){
            Console.Clear();
            Console.WriteLine("Bem vindo ao Quizz!!");
            Console.WriteLine("Teremos 7 perguntas variadas com alternativas");
            Console.WriteLine("vamos a primeira pergunta:");
            Console.Clear();


            Pergunta1();

        }
        static void Pergunta1(){
            Console.WriteLine("1 - As variaveis int , short e long sao de que tipo?");
            Console.WriteLine("a ) inteiros");
            Console.WriteLine("b ) reais");
            Console.WriteLine("c ) decimais ");
            string data = Console.ReadLine().ToLower();
           // char  res= char.Parse(data.Substring(0));
            char res = data[0];

            switch (res){
                case 'a': Console.WriteLine("RESPOSTA CERTA");break;
                case 'b':Console.WriteLine("RESPOSTA ERRADA");break;
                case 'c': Console.WriteLine("RESPOSTA ERRADA");break;
                default: Menu();break;
            }

            Thread.Sleep(2500);

            Pergunta2();
        }
        static void Pergunta2(){
            Console.Clear();
            Console.WriteLine("2 - No Windows terminal usamos dotnet clean para:");
            Console.WriteLine("a ) fazer a restauração do projeto");
            Console.WriteLine("b ) verificar erros");
            Console.WriteLine("c ) para limpar a cache dos ultimos builds");
            string data = Console.ReadLine().ToLower();
            char  resp= char.Parse(data.Substring(0));
        

            if(resp == 'a'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(resp == 'b'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(resp == 'c'){
            Console.WriteLine("Resposta Certa!!");
            Thread.Sleep(1000);
            }
            
            Console.Clear();
            Pergunta3();
        }
        static void Pergunta3(){
             Console.WriteLine("3 - Na conversao 'int num1 = float num;' podemos dizer que é:" );
            Console.WriteLine("a ) uma conversao implicita");
            Console.WriteLine("b ) uma conversao explicita");
            Console.WriteLine("c ) nao houve conversao");
            string data = Console.ReadLine().ToLower();
            char  respo= char.Parse(data.Substring(0));
        
            

            if(respo == 'a'){
            Console.WriteLine("Resposta Certa!!");
            Thread.Sleep(1000);
            }
            if(respo == 'b'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(respo == 'c'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            
            
            Console.Clear();
            Pergunta4();
        }
        static void Pergunta4(){
            Console.WriteLine("4 - Ao declarar uma variavel int e nao instanciala seu valor sera:");
            Console.WriteLine("a ) = $");
            Console.WriteLine("b ) = 0");
            Console.WriteLine("c ) = 127");
            string data = Console.ReadLine().ToLower();
            char  respos= char.Parse(data.Substring(0));

            if(respos == 'a'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(respos == 'b'){
            Console.WriteLine("Resposta Certa!!");
            Thread.Sleep(1000);
            }
            if(respos == 'c'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            
            Console.Clear(); 
            Pergunta5();
        }
        static void Pergunta5(){
            Console.WriteLine("5 - quais desses nao é um laco de repeticao?");
            Console.WriteLine("a ) For ");
            Console.WriteLine("b ) While ");
            Console.WriteLine("c ) Switch ");
            string data = Console.ReadLine().ToLower();
            char respost = char.Parse(data.Substring(0));

            if(respost == 'a'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(respost == 'b'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(respost == 'c'){
            Console.WriteLine("Resposta Certa!!");
            Thread.Sleep(1000);
            }
            
            Console.Clear();
            Pergunta6();
        }
        static void Pergunta6(){
              Console.WriteLine("6 - o if eh um operador");
            Console.WriteLine("a ) condicional");
            Console.WriteLine("b ) de atribuicao");
            Console.WriteLine("c ) de comparacao ");
            string data = Console.ReadLine().ToLower();
            char escolha = char.Parse(data.Substring(0));

            if(escolha == 'a'){
            Console.WriteLine("Resposta Certa!!");
            Thread.Sleep(1000);
            }
            if(escolha == 'b'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            if(escolha == 'c'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            
            Console.Clear();
            Pergunta7();
        }
        static void Pergunta7(){
             Console.WriteLine("7 - o C# é uma linguagem compilada , enquanto o java é:");
            Console.WriteLine("a ) dificil");
            Console.WriteLine("b ) interpretada");
            Console.WriteLine("c ) decifrada");
            string data = Console.ReadLine().ToLower();
            char res1 = char.Parse(data.Substring(0));

            if(res1 == 'a'){
            Console.WriteLine("Resposta Errada!!");
            Thread.Sleep(1000);
            }
            if(res1 == 'b'){
            Console.WriteLine("Resposta Certa!!");
            Thread.Sleep(1000);
            }
            if(res1 == 'c'){
            Console.WriteLine("Resposta Errada");
            Thread.Sleep(1000);
            }
            
            Console.Clear();

            Console.WriteLine("Parabéns vc encerrou esse quizz...");
            Console.WriteLine("Espero que tenha se saido bem");
            System.Console.WriteLine("Ate logo!!");
            Thread.Sleep(8000);
        

            Menu();
        }

        static void VerdadeiroOuFalso(){
        Console.Clear();
        Console.WriteLine("Bem vindo ao verdadei ou falso..");
        Console.WriteLine("Responda as perguntas com 'v' ou 'f' ");
        
        }
        static void Numeros(){}

    }
}
