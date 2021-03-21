using ConsoleApp2.Clases.ArbolBinarioOrdenado;
using ConsoleApp2.Clases.JuegoAnimal;
using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {


        //NUMERO DE NODOS
        public static int numNodos(Nodo raiz)
        {
            if (raiz == null)
            {
                return 0;
            }
            else
            {
                return 1 + numNodos(raiz.subarbolIzquierdo())
                        + numNodos(raiz.subarbolDerecho());
            }
        }

        /// RECORRIDOS DE LOS NODOS
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());
            }
        }

        // Recorrido de un árbol binario en inorden
        public static void inorden(Nodo r)
        {
            if (r != null)
            {
                inorden(r.subarbolIzquierdo());
                r.visitar();
                inorden(r.subarbolDerecho());
            }
        }

        // Recorrido de un árbol binario en postorden
        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }

        static void juegoAnimales()
        {
            Console.WriteLine("Juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("Jugamos otra vez?");
                otroJuego = juego.respuesta();
            } while (otroJuego);
        }

        public static void prueba_arbol_normal()
        {
            try
            {
                // TODO code application logic here
                ArbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();
                a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.nuevoArbol(null, "Fabrizio", null);
                a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a);
                a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
                a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a); // apilamos
                //desapilamos las ramas
                a2 = (Nodo)pila.Pop(); //desapilamos
                a1 = (Nodo)pila.Pop();


                a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
                arbol = new ArbolBinario(a);

                Console.WriteLine("Preorden:");
                preorden(a);

                Console.WriteLine("inorden:");
                inorden(a);


                Console.WriteLine("postorden:");
                postorden(a);

                //pausa para debug
                int pausa;
                pausa = 0;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups error " + ex.Message);
            }
        }

        public static void pruebaOrden()
            
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            String[] datos = { "Maria","Fabrizio","Gaby", "Andrea", "Abel", "Carmen", "Hector" };//hay te recordas que va ordenado cronologicamente, derecha mayor, izquierda menor:)
            Estudiante es = new Estudiante();

            foreach (String d in datos)
            {
                es.nombre = d;
                es.descripcion = $"insertar Nodo.{d}";
                ArBus.insertar(es);
                es = new Estudiante();
            }
            int pausa;
            pausa = 0;
            es = new Estudiante();
            es.nombre = "Gaby";
            es.descripcion = "Eliminar";
            ArBus.eliminar(es);
            pausa = 0;

            
            


        }
       



        static void Main(string[] args)
        {
            //prueba_arbol_normal();
            // juegoAnimales();
            pruebaOrden();
           




        }
    }
}
