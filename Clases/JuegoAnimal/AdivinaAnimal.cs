using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Clases.JuegoAnimal
{
    class AdivinaAnimal
    {
        private static Nodo raiz;

     public AdivinaAnimal()
        {
            raiz = new Nodo("Elefante");
        }



    public void jugar()
        {
            Nodo nodo = raiz;

            while(nodo != null)
            {
                if(nodo.izquierda != null) //hay una pregunta
                {
                    Console.WriteLine(nodo.valorNodo());
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;
                } else
                {
                    Console.WriteLine($"Ya se, es un {nodo.valorNodo()}");
                    if (respuesta())
                    {
                        Console.WriteLine("Gane :) !!");
                    } else
                    {
                        animalNuevo(nodo);
                    }
                        
                    nodo = null;
                    return;
                }
            }

        }


        private void animalNuevo(Nodo nodo)
        {
            String animalNodo = (String)nodo.valorNodo();    //(String)nodo.valor;
            Console.WriteLine("Cuál es tu animal?");
            String nuevoA = Console.ReadLine();
            Console.WriteLine("Qué pregunta con respuesta si/no puedo hacer" +
                     " para poder decir que es un(a) " + nuevoA);
            String pregunta = Console.ReadLine();
            Nodo nodo1 = new Nodo(animalNodo);
            Nodo nodo2 = new Nodo(nuevoA);
            Console.WriteLine("Para un(a) " + nuevoA + " la respuesta es si/no?");
            nodo.nuevoValor("" + pregunta + "?");
            if (respuesta())
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
            }
        }//end metodo



        public bool respuesta()
        {

            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();

                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o no");
            }
        }

    }//end class
}
