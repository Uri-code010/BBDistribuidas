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
            Nombre = nombre;
            Campos = campos;
            Condicion = condicion;
            TipoFragmentacion = tipoFragmentacion;
            ClavePrimaria = clavePrimaria;

        }
    }
}
