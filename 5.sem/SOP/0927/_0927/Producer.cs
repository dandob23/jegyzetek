﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0927
{
    internal class Producer
    {
        static uint ID;
        uint id;
        int amountToProduce;
        int productCount;
        bool isWorking;

        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Producer(int amountToProduce)
        {
            id = ID++;
            this.amountToProduce = amountToProduce;
            IsWorking = false;
        }

        public void Work()
        {
            productCount = 0;
            IsWorking = true;
            Product product = null;
            while (productCount<amountToProduce)
            {
                if (product==null)
                {
                    product = new Product();
                }
                if (Controller.TryProduce(this, product))
                {
                    productCount++;
                    Console.WriteLine($"{this} has produced {product}");
                    product = null;
                }
            }
            isWorking = false;
            Controller.CheckProducerWorkingState();
        }

        public override string ToString()
        {
            return $"Producer {id}";
        }



    }
}
