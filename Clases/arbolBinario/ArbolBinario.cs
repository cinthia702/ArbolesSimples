/**
 *
 * @author Ruldin
 */
public class ArbolBinario {

    protected Nodo raiz;

    public ArbolBinario() {
       // constructor con nulo
        raiz = null;
    }

    public ArbolBinario(Nodo raiz) {
        this.raiz = raiz;
    }

    public Nodo raizArbol() {
        return raiz;
    }
// Comprueba el estatus del árbol

    bool esVacio() {
        return raiz == null;
    }

    public static Nodo nuevoArbol(
            Nodo ramaIzqda, object dato, Nodo ramaDrcha) {
        return new Nodo(ramaIzqda, dato, ramaDrcha);
    }

}
