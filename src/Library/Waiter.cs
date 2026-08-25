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
        /// <summary>
        /// Nombre del mesero
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private ArrayList assignedTables = new ArrayList();

        /// <summary>
        /// Metodo para asignar mesa al mesero
        /// </summary>
        public void AssignTable(Table mesa)
        {
            assignedTables.Add(mesa);
        }

        /// <summary>
        /// Metodo para tomar orden
        /// </summary>
        public void TakeOrder(OrderCliente orden, Dish plato)
        {
            orden.AddToOrder(plato);
        }

        /// <summary>
        /// Constructor para la clase mesero
        /// </summary>
        public Waiter(string name)
        {
            this.name = name;
        }
    }
}