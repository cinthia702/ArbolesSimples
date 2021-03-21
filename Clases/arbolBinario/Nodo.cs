using System;


/**
 *
 * @author Ruldin
 */
public class Nodo {

    protected object dato;
    public Nodo izquierda;
    public Nodo derecha;

    
    public Nodo(object valor) {
        dato = valor;
        izquierda = derecha = null;
    }

    
    // Eliminar esto la primera vez
    public void visitar(){
        Console.WriteLine(dato+"<-->");
    }
    
    public Nodo(Nodo ramaIzdo, object valor, Nodo ramaDerecha) {
    //    this(dato);
        dato = valor;
        izquierda = ramaIzdo;
        derecha = ramaDerecha;
    }
// operaciones de acceso

    public object valorNodo() {
    //    return valor;
        return dato;
    }

    public Nodo subarbolIzquierdo() {
        return izquierda;
    }

    public Nodo subarbolDerecho() {
        return derecha;
    }

    public void nuevoValor(object d)
    {
        dato = d;
    }

    public void ramaIzdo(Nodo n) {
        izquierda = n;
    }

    public void ramaDcho(Nodo n) {
        derecha = n;
    }
}
