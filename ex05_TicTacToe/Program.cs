using System;

/*5. Create the tic tac toe game. The data must be stored in an array and the request played
position is provided by the user with two coordinates. The application must validate it the
user play is valid;*/

namespace TicTacToe
{
    class Program
    {

        int[] x = new int[3] { 1, 2, 3 };
        int[] y = new int[3] { 1, 2, 3 };
        char[] board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

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
            Console.WriteLine(Tabuleiro);
        }
        static void Tabuleiro()
        {
            {
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}");
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}");
                Console.WriteLine("     |     |     ");
            }
        }
    }
}