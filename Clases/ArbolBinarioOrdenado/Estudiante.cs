
using System;

public class Estudiante : Comparador {

    public String numMat;
    public String nombre;
    public String descripcion;



    public bool igualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) == 0;
    }

    public bool mayorIgualQue(object q)
    {
         Estudiante p2 = (Estudiante)q;

        return
        nombre.CompareTo(p2.nombre) >= 0;
    }

    public bool mayorQue(object q)
    {

        Estudiante p2 = (Estudiante)q;

        return
        nombre.CompareTo(p2.nombre) > 0;
    }

    public bool menorIgualQue(object q)
    {
      
        Estudiante p2 = (Estudiante)q;

        return
        nombre.CompareTo(p2.nombre) <= 0;
    }

    public bool menorQue(object q) {
        
        Estudiante p2 = (Estudiante)q;

        return
        nombre.CompareTo(p2.nombre) < 0;
     
    }


}
