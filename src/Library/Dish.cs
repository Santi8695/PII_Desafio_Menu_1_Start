//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string name;
        /// <summary>
        /// Representa el nombre del plato.
        /// </summary>
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
        private double price;
        /// <summary>
        /// Representa un el precio del plato.
        /// </summary>
        public double Price
        {
            get {return price;}
            set {price = value;}
        }
        private bool isVegetarian;
        /// <summary>
        /// Representa si el plato es vegetariano o no.
        /// </summary>
        public bool IsVegetarian
        {
            get {return isVegetarian;}
            set {isVegetarian = value;}
        }
        /// <summary>
        /// El constructor.
        /// </summary>
        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.isVegetarian = IsVegetarian;
        }
    }
}