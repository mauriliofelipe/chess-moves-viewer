using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMovesViewer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        // Retorna uma lista de coordenadas representando movimentos retos no tabuleiro
        private List<Tuple<int, int>> GetStraightMoves(int row, int col, int maxSteps = 7)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

            // Movimentos para cima
            for (int i = row - 1; i >= Math.Max(row - maxSteps, 0); i--)
            {
                moves.Add(Tuple.Create(i, col));
            }

            // Movimentos para baixo
            for (int i = row + 1; i <= Math.Min(row + maxSteps, 7); i++)
            {
                moves.Add(Tuple.Create(i, col));
            }

            // Movimentos para a esquerda
            for (int j = col - 1; j >= Math.Max(col - maxSteps, 0); j--)
            {
                moves.Add(Tuple.Create(row, j));
            }

            // Movimentos para a direita
            for (int j = col + 1; j <= Math.Min(col + maxSteps, 7); j++)
            {
                moves.Add(Tuple.Create(row, j));
            }

            return moves;
        }

        // Retorna uma lista de coordenadas representando movimentos diagonais no tabuleiro
        private List<Tuple<int, int>> GetDiagonalMoves(int row, int col, int maxSteps = 7)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

            // Movimentos na diagonal superior esquerda
            for (int i = 1; i <= Math.Min(row, col) && i <= maxSteps; i++)
            {
                moves.Add(Tuple.Create(row - i, col - i));
            }

            // Movimentos na diagonal superior direita
            for (int i = 1; i <= Math.Min(row, 7 - col) && i <= maxSteps; i++)
            {
                moves.Add(Tuple.Create(row - i, col + i));
            }

            // Movimentos na diagonal inferior esquerda
            for (int i = 1; i <= Math.Min(7 - row, col) && i <= maxSteps; i++)
            {
                moves.Add(Tuple.Create(row + i, col - i));
            }

            // Movimentos na diagonal inferior direita
            for (int i = 1; i <= Math.Min(7 - row, 7 - col) && i <= maxSteps; i++)
            {
                moves.Add(Tuple.Create(row + i, col + i));
            }

            return moves;
        }

        // Retorna uma lista de coordenadas representando movimentos do cavalo no tabuleiro
        private List<Tuple<int, int>> GetKnightMoves(int row, int col)
        {
            List<Tuple<int, int>> moves = new List<Tuple<int, int>>
            {

                // Movimentos do cavalo (em formato de "L")
                Tuple.Create(row - 2, col - 1),
                Tuple.Create(row - 2, col + 1),
                Tuple.Create(row - 1, col - 2),
                Tuple.Create(row - 1, col + 2),
                Tuple.Create(row + 1, col - 2),
                Tuple.Create(row + 1, col + 2),
                Tuple.Create(row + 2, col - 1),
                Tuple.Create(row + 2, col + 1)
            };

            return moves;
        }

        // Obtém os movimentos possíveis para uma determinada peça em uma posição específica.
        private List<Tuple<int, int>> GetPossibleMoves(string piece, int row, int col)
        {
            // Lista que armazena os movimentos possíveis
            List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

            switch (piece)
            {
                case "Rei":
                    // Exemplo: Movimentos do rei (cima, baixo, esquerda, direita e diagonais)
                    possibleMoves.AddRange(GetStraightMoves(row, col, 1));
                    possibleMoves.AddRange(GetDiagonalMoves(row, col, 1));
                    break;

                case "Rainha":
                    // Exemplo: Movimentos da rainha (cima, baixo, esquerda, direita e diagonais)
                    possibleMoves.AddRange(GetStraightMoves(row, col));
                    possibleMoves.AddRange(GetDiagonalMoves(row, col));
                    break;

                case "Torre":
                    // Exemplo: Movimentos da torre (cima, baixo, esquerda e direita)
                    possibleMoves.AddRange(GetStraightMoves(row, col));
                    break;

                case "Bispo":
                    // Exemplo: Movimentos do bispo (diagonais)
                    possibleMoves.AddRange(GetDiagonalMoves(row, col));
                    break;

                case "Cavalo":
                    // Exemplo: Movimentos do cavalo
                    possibleMoves.AddRange(GetKnightMoves(row, col));
                    break;

                default:
                    break;
            }

            // Filtra apenas os movimentos válidos dentro do tabuleiro (0-7)
            possibleMoves = possibleMoves.Where(move =>
                move.Item1 >= 0 && move.Item1 <= 7 && move.Item2 >= 0 && move.Item2 <= 7)
                .ToList();

            return possibleMoves;
        }



    }
}
