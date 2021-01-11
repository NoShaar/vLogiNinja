using System;

namespace LogiNinja
{
    class Program
    {
        
        enum Opcao {Logar=1,Cadastrar,Fechar}
        enum cor {Vermelho=1,Roxo,Azul,Amarelo,Verde,Preto,Branco,Outros}
        //cadastro abaixo
        static string user;
        static string nome;
        static string userColor;
        static int userAge;
        static int senha;
 
        static void Main()
        {

            Console.WriteLine("Esse Programa é Apenas Uma Versão Simples De Sistema De Login Com Variáveis Para Estudos!");
            Console.WriteLine("Se Você Pagou Por Esse Programa Você Foi ''ENGANADO'' ");
            Console.WriteLine("By: NinjaNoobPlay-2021");
            Console.WriteLine("Versão: 1.0.0");
            Console.WriteLine("");
            Console.WriteLine("Escolha Uma Opção Abaixo: ");
            Console.Write("1-Logar\n2-Cadastrar\n3-Fechar\nOpção: ");
            int selectOpcoes = int.Parse(Console.ReadLine());
            Opcao escolhiOpcao = (Opcao)selectOpcoes; 

            

            switch(escolhiOpcao){
                case Opcao.Cadastrar:
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("REGISTRAR-SE"));
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Digite Seu Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Qual Sua Cor Favorita: ");
                Console.Write("1-Vermelho\n2-Roxo\n3-Azul\n4-Amarelo\n5-Verde\n6-Preto\n7-Branco\n8-Outros\nOpção: ");
                int selectColor =int.Parse(Console.ReadLine());
                cor opcaoCor= (cor)selectColor;
                switch(opcaoCor){
                    case cor.Amarelo:
                    userColor="Amarelo";
                    break;
                    case cor.Azul:
                    userColor="Azul";
                    break;
                    case cor.Branco:
                    userColor="Branco";
                    break;
                    case cor.Preto:
                    userColor="Preto";
                    break;
                    case cor.Roxo:
                    userColor="Roxo";
                    break;
                    case cor.Verde:
                    userColor="Verde";
                    break;
                    case cor.Vermelho:
                    userColor="Vermelho";
                    break;
                    case cor.Outros:
                    userColor="Outros";
                    break;
                }
                Console.Write("Digite Sua Idade: ");
                userAge =int.Parse(Console.ReadLine());
                Console.Write("Digite Seu Usuário: ");
                user = Console.ReadLine();
                Console.Write("Digite Sua Senha: ");
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Cadastrado Com Sucesso!");
                Console.WriteLine("");
                Main();
                break;
                case Opcao.Logar:
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("LOGAR"));
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Usuario: ");
                string respUser= Console.ReadLine();
                Console.Write("Senha: ");
                int respSenha= int.Parse(Console.ReadLine());
                if(respUser==user&&respSenha==senha){
                    Console.WriteLine("");
                    Console.WriteLine("Logado Com Sucesso!");
                    Console.WriteLine("");
                    Console.WriteLine("Buscando Dados...");
                    Console.Write("Pressione Enter Para Continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Dados Cadastrais Abaixo! ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Seu Nome é: "+nome);
                    Console.WriteLine("Sua Cor Favorita é: "+userColor);
                    Console.WriteLine("Sua Idade é: "+userAge+" Anos");
                    Console.WriteLine("Seu Usuario é: "+user);
                    Console.WriteLine("Sua Senha é: "+senha);
                    Console.WriteLine("");
                    
                    Main();
                }else{
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Usuario/Senha Incorretos Ou Não Cadastrados!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Main();
                }
                
                break;
                case Opcao.Fechar:
                Console.WriteLine("");
                Console.WriteLine("Fechando O Programa!");
                Console.WriteLine("");
                break;
                default:
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Opção Não Encontrada!");
                Console.WriteLine("");
                Console.WriteLine("");
                Main();
                break;
            }     
        
        }
    }
}
