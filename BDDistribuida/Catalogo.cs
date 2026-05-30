using System;
using System.Collections.Generic;
using System.Text;

namespace BDDistribuida
{
    //clase catalogo. qué framento, donde se encuentra, a qué tabla corresponde, etc.
    internal class Catalogo
    {
        public int Id { get; set; } 
        public string FragmentoNombre { get; set; }
        public string Nodo { get; set; }

        public string Tipo { get; set; } 

        public Catalogo(int id, string fragmentoNombre, string nodo, string tipo)
        {
            Id = id; // identificador único del fragmento en el catálogo
            FragmentoNombre = fragmentoNombre; // a qué fragmento corresponde según su nombre
            Nodo = nodo; // en qué nodo se encuentra el fragmento
            Tipo = tipo; // primario o replicado
        }
    }
}
