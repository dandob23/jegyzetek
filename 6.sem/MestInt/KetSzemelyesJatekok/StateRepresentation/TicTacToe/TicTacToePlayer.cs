﻿using KetSzemelyesJatekok.Interfaces;
using KetSzemelyesJatekok.Solvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetSzemelyesJatekok.StateRepresentation.TicTacToe
{
    internal class TicTacToePlayer
    {

        private Solver solver;

        public TicTacToePlayer()
        {
            solver = new TrialAndError(new TicTacToeOperatorGenerator());
        }

        public void Play()
        {
            State state = new TicTacToeState();

            Console.WriteLine(state);

            while (state.GetStatus() == Status.PLAYING)
            {
                Operator o;
                do
                {
                    int x = 0;
                    do
                    {
                        Console.Write("X: ");
                    } while (!int.TryParse(Console.ReadLine(), out x));

                    int y = 0;
                    do
                    {
                        Console.Write("Y: ");
                    } while (!int.TryParse(Console.ReadLine(), out y));

                    o = new TicTacToeOperator(x, y, TicTacToeState.PLAYER1);

                } while (!o.IsApplicable(state));

                state = o.Apply(state);

                Console.WriteLine(state);

                if (CheckStatus(state))
                {
                    break;
                }

                state = solver.NextMove(state);

                Console.WriteLine(state);

                if (CheckStatus(state))
                {
                    break;
                }
            }
        }

        private bool CheckStatus(State state)
        {
            if (state.GetStatus() == Status.PLAYER1WINS)
            {
                Console.WriteLine("PLAYER1 Won...");
                return true;
            }

            if (state.GetStatus() == Status.PLAYER2WINS)
            {
                Console.WriteLine("PLAYER2 Won...");
                return true;
            }

            if (state.GetStatus() == Status.DRAW)
            {
                Console.WriteLine("DRAW...");
                return true;
            }

            return false;
        }
    }
}
