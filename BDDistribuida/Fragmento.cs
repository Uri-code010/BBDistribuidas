using System;
using System.Collections.Generic;
using System.Text;

namespace BDDistribuida
{
    internal class Fragmento
    {
        public string TablaOriginal { get; set; }
        public string Nombre { get; set; }
        public List<string> Campos { get; set; } 
        public string Condicion { get; set; }

        public string TipoFragmentacion { get; set; } 

        public string ClavePrimaria { get; set; } 

        public Fragmento(string tablaOriginal, string nombre, List<string> campos, string condicion, string tipoFragmentacion, string clavePrimaria)
        {
            TablaOriginal = tablaOriginal;
            Nombre = nombre; //el nombre del fragmento, por ejemplo: "Fragmento1"
            Campos = campos; // los campos que contiene el fragmento, por ejemplo: ["id", "nombre"] para un fragmento vertical
            Condicion = condicion; // la condición de fragmentación, por ejemplo: "id < 1000" para un fragmento horizontal
            TipoFragmentacion = tipoFragmentacion; // el tipo de fragmentación, por ejemplo: "horizontal", "vertical" o "mixta"
            ClavePrimaria = clavePrimaria;

        }

        public string Descripcion()
        {
            return $"({Nombre}) ({TipoFragmentacion})";
        }
    }
}
