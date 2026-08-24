//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        private ArrayList order = new ArrayList();

        public int Number { get; }

        public bool IsOccupied { get; private set; }

        public ArrayList Order
        {
            get { return this.order; }
        }
        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in order)
            {
                total += dish.Price;
            }
            return total;
        }
        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
        }
        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}