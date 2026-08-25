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
        private OrderCliente order;

        public int Number { get; }

        public bool IsOccupied { get; private set; }

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
        }
    }
}