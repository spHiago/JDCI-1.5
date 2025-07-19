using System;

/*5. Create the tic tac toe game. The data must be stored in an array and the request played
position is provided by the user with two coordinates. The application must validate it the
user play is valid;*/

namespace TicTacToe
{
    class Program
    {
       static char[] board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' '};

        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo ao TicTaeToe!");
            Console.WriteLine("Para este jogo, precisaremos de dois jogadores.");
            Console.WriteLine("Digite o nome do jogador 1:");
            string jogador1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do jogador2");
            string jogador2 = Console.ReadLine();
            Console.WriteLine($"Jogador1 = {jogador1}");
            Console.WriteLine($"Jogador2 = {jogador2}");
            Console.WriteLine($"{jogador1}: X    {jogador2}: O");
            Tabuleiro();
            Console.WriteLine($"{jogador1}, é sua vez! Você joga com 'X'.");
            int linha, coluna, indice;

            while (true)
            {

                Console.Write("Digite a linha (0, 1 ou 2): ");
                linha = int.Parse(Console.ReadLine());
                Console.Write("Digite a coluna (0, 1 ou 2): ");
                coluna = int.Parse(Console.ReadLine());
                indice = linha * 3 + coluna;

                if (indice < 0 || indice > 9)
                {
                    Console.WriteLine("Posição invalida, tente novamente.");
                    continue;
                }
                if (board[indice] != ' ')
                Console.WriteLine("Essa posição ja esta ocupada, escolha outra");
                else
                {
                    board[indice] = 'X';
                    break;
                }
                Tabuleiro();
            }
 
        }
        static void Tabuleiro()
        {
            {
                Console.WriteLine("     COLUNAS    ");
                Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}            LINHA 0");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}            LINHA 1");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}            LINHA 2");
                Console.WriteLine("     |     |     ");
            }
        }
    }
}