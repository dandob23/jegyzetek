﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszemelyesJatekok.StateRepresentations.One_Three
{
    internal class OneThreeState
    {
        public int X;
        public int Y;

        public static int[,] Table { get; set; } = new int[7, 10]
        {
                { 1, 5, 3, 4, 3, 6, 7, 1, 1, 6 },
                { 4, 4, 3, 4, 2, 6, 2, 6, 2, 5 },
                { 1, 3, 9, 4, 5, 2, 4, 2, 9, 5 },
                { 5, 2, 3, 5, 5, 6, 4, 6, 2, 4 },
                { 1, 3, 3, 2, 5, 6, 5, 2, 3, 2 },
                { 2, 5, 2, 5, 5, 6, 4, 8, 6, 1 },
                { 9, 2, 3, 6, 5, 6, 2, 2, 2, 0 }
        };

        public OneThreeState()
        {
            X = 0;
            Y = 0;
        }

        public object Clone()
        {
            OneThreeState clone = new OneThreeState();

            clone.X = X;
            clone.Y = Y;

            return clone;
        }

        public bool IsTargetState()
        {
            return X == 6 && Y == 9;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is OneThreeState)) return false;
            
            OneThreeState other = obj as OneThreeState;

            return other.X == X && other.Y == Y;
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            for (int i = 0; i < Table.GetLength(0); i++)
            {
                sr.Append("\n");
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if (X == i && Y == j)
                    {
                        sr.Append(" B ");
                    }
                    else
                    {
                        sr.Append($" {Table[X, Y]} ");
                    }
                }
            }
            sr.Append($" Character field: {Table[X, Y]}");
            return sr.ToString();
        }
    }
}
