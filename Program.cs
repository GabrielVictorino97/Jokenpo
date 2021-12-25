using System;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEscolha;
            Console.Title = ("Jokenpô");
            do
            {
                Console.WriteLine("------------------------------------");
                EscreveColorido("Digite 0 para Pedra, 1 para Papel, 2 para Tesoura, 3 para Lagarto e 4 para Spock" +
                    " (digite '6' para sair):", ConsoleColor.Blue);
                Console.ForegroundColor = ConsoleColor.Magenta;

                var entrada = Console.ReadLine();
                if (entrada == "6")
                    break;

                numeroEscolha = Convert.ToInt32(entrada);
                var suaEscolha = RetornaSuaEscolha(numeroEscolha);

                var NumAleatorio = new Random();
                var escolhaPC = RetornaPC(NumAleatorio.Next(3));

                EscreveColorido("Você: " + suaEscolha, ConsoleColor.Yellow);
                EscreveColorido("X", ConsoleColor.Cyan);
                EscreveColorido("PC: " + escolhaPC, ConsoleColor.Yellow);
                Console.WriteLine("------------------------------------");
                var resultado = RetornaResultado(suaEscolha, escolhaPC);
                EscreveColorido(resultado, ConsoleColor.Yellow);
                Console.WriteLine("");
                var explicaResultado = ExplicacaoResultado(suaEscolha, escolhaPC);
                EscreveColorido(explicaResultado, ConsoleColor.Yellow);
                Console.WriteLine("------------------------------------");
                EscreveColorido("Pressione qualquer tecla para continuar", ConsoleColor.Red);

                EscreveColorido("Para limpar o histórico, digite '5'", ConsoleColor.Blue);
                var limpar = Console.ReadLine();

                if (limpar == "5")
                    Console.Clear();

                Console.WriteLine("");
            } while (numeroEscolha != 6);

            Console.WriteLine("Volte seeeempre!!");
        }
        static string ExplicacaoResultado(string suaEscolha, string escolhaPc)
        {
            if (suaEscolha == escolhaPc)
                return "Escolhas iguais";

            if (suaEscolha == "Tesoura" && escolhaPc == "Papel" || escolhaPc == "Tesoura" && suaEscolha == "Papel")
                return "Tesoura Corta Papel";
            else if (suaEscolha == "Papel" && escolhaPc == "Pedra" || escolhaPc == "Papel" && suaEscolha == "Pedra")
                return "Papel cobre Pedra";
            else if (suaEscolha == "Pedra" && escolhaPc == "Lagarto" || escolhaPc == "Pedra" && suaEscolha == "Lagarto")
                return "Pedra esmaga Lagarto";
            else if (suaEscolha == "Lagarto" && escolhaPc == "Spock" || escolhaPc == "Lagarto" && suaEscolha == "Spock")
                return "Lagarto envenena Spock";
            else if (suaEscolha == "Spock" && escolhaPc == "Tesoura" || escolhaPc == "Spock" && suaEscolha == "Tesoura")
                return "Spock esmaga(ou derrete) Tesoura";
            else if (suaEscolha == "Tesoura" && escolhaPc == "Lagarto" || escolhaPc == "Tesoura" && suaEscolha == "Lagarto")
                return "Tesoura decapita Lagarto";
            else if (suaEscolha == "Lagarto" && escolhaPc == "Papel" || escolhaPc == "Lagarto" && suaEscolha == "Papel")
                return "Lagarto come Papel";
            else if (suaEscolha == "Papel" && escolhaPc == "Spock" || escolhaPc == "Papel" && suaEscolha == "Spock")
                return "Papel refuta Spock";
            else if (suaEscolha == "Spock" && escolhaPc == "Pedra" || escolhaPc == "Spock" && suaEscolha == "Pedra")
                return "Spock vaporiza Pedra";
            else if (suaEscolha == "Pedra" && escolhaPc == "Tesoura" || escolhaPc == "Pedra" && suaEscolha == "Tesoura")
                return "Pedra amassa tesoura";

            return "Alguém escolheu errado";

        }
        static string RetornaResultado(string suaEscolha, string escolhaPC)
        {
            if (    suaEscolha == "Pedra" && escolhaPC == "Tesoura"
                   || suaEscolha == "Tesoura" && escolhaPC == "Papel"
                   || suaEscolha == "Papel" && escolhaPC == "Pedra"
                   || suaEscolha == "Pedra" && escolhaPC == "Lagarto"
                   || suaEscolha == "Lagarto" && escolhaPC == "Spock"
                   || suaEscolha == "Lagarto" && escolhaPC == "Papel"
                   || suaEscolha == "Spock" && escolhaPC == "Tesoura"
                   || suaEscolha == "Tesoura" && escolhaPC == "Lagarto"
                   || suaEscolha == "Papel" && escolhaPC == "Spock"
                   || suaEscolha == "Spock" && escolhaPC == "Pedra")
                return "JOGADOR VENCEU";
            else if (escolhaPC == "Pedra" && suaEscolha == "Tesoura"
                   || escolhaPC == "Tesoura" && suaEscolha == "Papel"
                   || escolhaPC == "Papel" && suaEscolha == "Pedra"
                   || escolhaPC == "Pedra" && suaEscolha == "Lagarto"
                   || escolhaPC == "Lagarto" && suaEscolha == "Spock"
                   || escolhaPC == "Lagarto" && suaEscolha == "Papel"
                   || escolhaPC == "Spock" && suaEscolha == "Tesoura"
                   || escolhaPC == "Tesoura" && suaEscolha == "Lagarto"
                   || escolhaPC == "Papel" && suaEscolha == "Spock"
                   || escolhaPC == "Spock" && suaEscolha == "Pedra")
                return "PC VENCEU";

            return "EMPATE";
        }
        static string RetornaSuaEscolha(int escolha)
        {
            if (escolha == 0)
                return "Pedra";
            else if (escolha == 1)
                return "Papel";
            else if (escolha == 2)
                return "Tesoura";
            else if (escolha == 3)
                return "Lagarto";
            else if (escolha == 4)
                return "Spock";
            else if (escolha == 6)
                return " >>Saindo<<";
            else
                return "Não ha essa escolha, tente novamente...";
        }
        static string RetornaPC(int escolhaPC)
        {
            if (escolhaPC == 0)
                return "Pedra";
            else if (escolhaPC == 1)
                return "Papel";
            else if (escolhaPC == 2)
                return "Tesoura";
            else if (escolhaPC == 3)
                return "Lagarto";
            else
                return "Spock";
          
        }
        static void EscreveColorido(string frase, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(frase);
        }
    }
}