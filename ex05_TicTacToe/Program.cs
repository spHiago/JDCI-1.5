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
            int linha, coluna, indice;

            while (!CheckWinX() || !CheckWinO())
            {
                Console.WriteLine($"{jogador1}, é sua vez! Você joga com 'X'.");
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
                {
                    Console.WriteLine("Essa posição ja esta ocupada, escolha outra");
                    continue;
                }
                else
                {
                    board[indice] = 'X';
                    continue;
                }
                if (CheckWinX())
                {
                    Console.WriteLine($"{jogador1} venceu. Fim de jogo.");
                    break;
                }
                if (CheckWinO())
                {
                    Console.WriteLine($"{jogador2} venceu. Fim de jogo.");
                    break;
                }
            }
            Tabuleiro();

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

        static bool CheckWinX()
        {
            if (board[0] == 'X' &&  board[1] == 'X' && board[2] == 'X')
                return true;
            if (board[3] == 'X' && board[4] == 'X' && board[5] == 'X')
                return true;
            if (board[6] == 'X' && board[7] == 'X' && board[8] == 'X')
                return true;

            if (board[0] == 'X' && board[4] == 'X' && board[8] == 'X')
                return true;
            if (board[2] == 'X' && board[4] == 'X' && board[6] == 'X')
                return true;
            else
                return false;
        }

        static bool CheckWinO()
        {
            if (board[0] == 'O' && board[1] == 'O' && board[2] == 'O')
                return true;
            if (board[3] == 'O' && board[4] == 'O' && board[5] == 'O')
                return true;
            if (board[6] == 'O' && board[7] == 'O' && board[8] == 'O')
                return true;

            if (board[0] == 'O' && board[4] == 'O' && board[8] == 'O')
                return true;
            if (board[2] == 'O' && board[4] == 'O' && board[6] == 'O')
                return true;
            else return false;
        }
    }
}