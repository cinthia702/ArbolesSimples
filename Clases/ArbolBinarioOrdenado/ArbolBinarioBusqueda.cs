using System;
/**
*
* @author cinthia
*/
public class ArbolBinarioBusqueda : ArbolBinario {

    public ArbolBinarioBusqueda() : base()
    {
        
    }

    public Nodo buscar(object buscado) { 
        Comparador dato;
        dato = (Comparador) buscado;
        if (raiz == null) {
            return null;
        } else {
            return localizar(raizArbol(), dato);
        }
    }

    
    protected Nodo localizar(Nodo raizSub, Comparador buscado) {
        if (raizSub == null) {
            return null;
        } else if (buscado.igualQue(raizSub.valorNodo())) {
            return raiz;
        } else if (buscado.menorQue(raizSub.valorNodo())) {
            return localizar(raizSub.subarbolIzquierdo(), buscado);
        } else {
            return localizar(raizSub.subarbolDerecho(), buscado);
        }
    }

    public Nodo buscarIterativo(object buscado) {
        Comparador dato;
        bool encontrado = false;
        Nodo raizSub = raiz;
        dato = (Comparador) buscado;
        while (!encontrado && raizSub != null) {
            if (dato.igualQue(raizSub.valorNodo())) {
                encontrado = true;
            } else if (dato.menorQue(raizSub.valorNodo())) {
                raizSub = raizSub.subarbolIzquierdo();
            } else {
                raizSub = raizSub.subarbolDerecho();
            }
        }
        return raizSub;
        //return dato;
    }

    //porque insertar se repite en esta misma clase?
    public void insertar(object valor)  {
        Comparador dato;
        dato = (Comparador) valor;
        raiz = insertar(raiz, dato);
    }
//método interno para realizar la operación

    protected Nodo insertar(Nodo raizSub, Comparador dato)  {
        if (raizSub == null) {
            raizSub = new Nodo(dato);
        } else if (dato.menorQue(raizSub.valorNodo())) {
            Nodo iz;
            iz = insertar(raizSub.subarbolIzquierdo(), dato);
            raizSub.ramaIzdo(iz);
        } else if (dato.mayorQue(raizSub.valorNodo())) {
            Nodo dr;
            dr = insertar(raizSub.subarbolDerecho(), dato);
            raizSub.ramaDcho(dr);
        } else {
            // throw new Exception("Nodo duplicado");
            Console.WriteLine($"duplicado!!!! {raizSub.valorNodo()}");
        }
        return raizSub;
    }

    public void eliminar(object valor)
    {
        Comparador dato;
        dato = (Comparador)valor;
        raiz = eliminar(raiz, dato);

    }
    //método interno para realizar la operación

    protected Nodo eliminar(Nodo raizSub, Comparador dato)
    {
        if (raizSub == null)
        {
            throw new Exception("No encontrado el nodo con la clave");
        }
        else if (dato.menorQue(raizSub.valorNodo()))
        {
            Nodo iz;
            iz = eliminar(raizSub.subarbolIzquierdo(), dato);
            raizSub.ramaIzdo(iz);
        }
        else if (dato.mayorQue(raizSub.valorNodo()))
        {
            Nodo dr;
            dr = eliminar(raizSub.subarbolDerecho(), dato);
            raizSub.ramaDcho(dr);
        }
        else // Nodo encontrado
        {
            Nodo q;
            q = raizSub; // nodo a quitar del árbol, este es el nodo que se quita del arbol
            if (q.subarbolIzquierdo() == null)
            {
                raizSub = q.subarbolDerecho();
            }
            else if (q.subarbolDerecho() == null)
            {
                raizSub = q.subarbolIzquierdo();
            }
            else
            { // tiene rama izquierda y derecha
                q = reemplazar(q);
            }
            q = null;
        }
        return raizSub;
    }
    // método interno para susutituir por el mayor de los menores

    private Nodo reemplazar(Nodo act) {
        Nodo a, p;
        p = act;
        a = act.subarbolIzquierdo(); // rama de nodos menores
        while (a.subarbolDerecho() != null) {
            p = a;
            a = a.subarbolDerecho();
        }
        act.nuevoValor(a.valorNodo());
        if (p == act) {
            p.ramaIzdo(a.subarbolIzquierdo());
        } else {
            p.ramaDcho(a.subarbolIzquierdo());
        }
        return a;
    }

}
