using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Clases.ArbolBinarioOrdenado
{
    class SoloNumeros : Comparador
    {
        public string nombre;
        public bool igualQue(object q)
        {
            //para la busqueda
            return true;
        }

        public bool mayorIgualQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return nombre.CompareTo(p2.nombre) >=0;
        }

        public bool mayorQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return nombre.CompareTo(p2.nombre) >0;
        }

        public bool menorIgualQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return nombre.CompareTo( p2.nombre) <=0;
        }

        public bool menorQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return nombre.CompareTo( p2.nombre) < 0;
        }

    }

}
