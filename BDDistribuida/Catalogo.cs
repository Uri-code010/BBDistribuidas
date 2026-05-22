using System;
using System.Collections.Generic;
using System.Text;

namespace BDDistribuida
{
    internal class Catalogo
    {
        public int Id { get; set; } 
        public string FragmentoNombre { get; set; }
        public string Nodo { get; set; }

        public string Tipo { get; set; } 

        public Catalogo(int id, string fragmentoNombre, string nodo, string tipo)
        {
            Id = id;
            FragmentoNombre = fragmentoNombre;
            Nodo = nodo;
            Tipo = tipo;
        }
    }
}
