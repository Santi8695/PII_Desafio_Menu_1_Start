//------------------------------------------------------------------------------
// <copyright file="Order.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class OrderCliente
    {
        private ArrayList order = new ArrayList();

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