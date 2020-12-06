using System;

namespace Orientação_obj___02_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Digite o nome do aluno");
            aluno1.nome = Console.ReadLine();
           
            Console.WriteLine("Digite o curso do aluno");
            aluno1.curso = Console.ReadLine();
            
            Console.WriteLine("Digite a idade");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o rg do aluno");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("Digite a média do aluno");
            aluno1.mediaFinal  = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da mensalidade do aluno");
            aluno1.valorMensalidade  = float.Parse(Console.ReadLine());

            Console.WriteLine("O aluno é bolsista? - s ou n");
            string resposta = Console.ReadLine();
            if(resposta == "s"){
                aluno1.bolsista = true;
            }else{
                aluno1.bolsista = false;
            }

            // Menu
            
            int opcao = 0;
            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Ver média do Aluno");
                Console.WriteLine("[2] - Ver mensalidade do Aluno");
                Console.WriteLine("[3] - Sair");
                opcao = int.Parse(Console.ReadLine());

            
            switch(opcao)
            {
                case 1:
                    Console.WriteLine($"a média dinal do aluno {aluno1.nome} = {aluno1.VerMediaAluno()}");
                    break;

                case 2:
                    Console.WriteLine($"O valor da mesanlidade do aluno fica em: {aluno1.VerMensalidade()}");
                    break;

                case 3: 
                    Console.WriteLine("Obrigado por acessar");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;



            }

            }while(opcao != 0);

           

            Console.WriteLine("");

        }
    }
}
