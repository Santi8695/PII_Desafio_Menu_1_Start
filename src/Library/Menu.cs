//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private ArrayList dishes = new ArrayList();

        /// <summary>
        /// Metodo para agregar platos al menu
        /// </summary>
        public void AddDish(Dish plato)
        {
            dishes.Add(plato);
        }

        /// <summary>
        /// Metodo para eliminar platos del menu
        /// </summary>
        public void RemoveDish(Dish plato)
        {
            dishes.Remove(plato);
        }

        /// <summary>
        /// Metodo para buscar plato por nombre
        /// </summary>

        public Dish GetDishByName(string platoBuscado)
        {
            foreach (Dish plato in dishes)
            {
                if (plato.Name == platoBuscado)
                {
                    return plato;
                }
            }
            return null;
        }

    }
}