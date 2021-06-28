using System;

namespace Arboles1._3.consola
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Nodo Raiz = new Nodo
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                       Valor = "+",
                       Hijos =
                       {
                            new Nodo
                            {
                               Valor = "8"
                            },
                            new Nodo
                            {
                               Valor = "5"
                            }
                       }
                    },
                    new Nodo
                    {
                       Valor = "-",
                       Hijos =
                       {
                            new Nodo
                            {
                               Valor = "7"
                            },
                            new Nodo
                            {
                               Valor = "4"
                            }
                       }
                    },
                    new Nodo
                    {
                       Valor = "/",
                       Hijos =
                       {
                            new Nodo
                            {
                               Valor = "6"
                            },
                            new Nodo
                            {
                               Valor = "8"
                            }
                       }
                    }
                }
            };
            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(Raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(Raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPosfijo(Raiz));
        }
    }
}
