
/**
 *
 * @author Ruldin
 */
public class clsRecorridos {
    // Recorrido de un árbol binario en preorden
     
    public static void preorden(Nodo r) {
        if (r != null) {
            r.visitar();
            preorden(r.subarbolIzquierdo());
            preorden(r.subarbolDerecho());
        }
    } 


// Recorrido de un árbol binario en inorden
    public static void inorden(Nodo r) {
        if (r != null) {
            inorden(r.subarbolIzquierdo());
            r.visitar();
            inorden(r.subarbolDerecho());
        }
    } 

// Recorrido de un árbol binario en postorden
    public static void postorden(Nodo r) {
        if (r != null) {
            postorden(r.subarbolIzquierdo());
            postorden(r.subarbolDerecho());
            r.visitar();
        }
    }
} //ec
