﻿using KetSzemelyesJatekok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetSzemelyesJatekok.Solvers
{
    public class TrialAndError:Solver
    {
        private Random rnd;

        public TrialAndError(OperatorGenerator operatorGenerator):base(operatorGenerator)
        {
            rnd = new Random();
        }

        private Operator SelectOperator(State currentState)
        {
            List<int> indexList = new List<int>();
            
            while (indexList.Count() < Operators.Count)
            {
                int index = rnd.Next(0, Operators.Count);
                
                while (indexList.Contains(index))
                {
                    index = rnd.Next(0, Operators.Count);
                }

                indexList.Add(index);
            }

            foreach (int index in indexList)
            {
                if (Operators[index].IsApplicable(currentState))
                {
                    return Operators[index];
                }
            }

            return null;
        }

        public override State NextMove(State state)
        { 
            Operator op = SelectOperator(state);

            if (op != null)
            {
                return op.Apply(state);
            }

            return null;
        }
    }
}
