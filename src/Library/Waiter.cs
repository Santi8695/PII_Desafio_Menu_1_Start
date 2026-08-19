//------------------------------------------------------------------------------
// <copyright file="Waiter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
        public void AssignTable(Table mesa)
        {
            assignedTables.Add(mesa);
        }
        public void TakeOrder(Table mesa, Dish plato)
        {
            mesa.Order.add(plato)
        }
        private ArrayList assignedTables = new ArrayList();
    }
}