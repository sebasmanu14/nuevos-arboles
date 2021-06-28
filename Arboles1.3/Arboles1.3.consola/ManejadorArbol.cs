using System.Linq;

namespace Arboles1._3.consola
{
    partial class Program
    {
        class ManejadorArbol 
        {
            public string ImprimirArbolInfijo(Nodo nodo)
            {
                //analiza el conenido de una hoja 
                if (!nodo.Hijos.Any())
                    return nodo.Valor;
                //analizo cuando no soy hoja 
                return $"( {ImprimirArbolInfijo(nodo.Hijos[0])}  {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])})";
            }

            internal string ImprimirArbolPrefijo(Nodo nodo)
            {
                //analiza el conenido de una hoja 
                if (!nodo.Hijos.Any())
                    return nodo.Valor;
                //analizo cuando no soy hoja
                return $"( {nodo.Valor} {ImprimirArbolPrefijo(nodo.Hijos[0])}  {ImprimirArbolPrefijo(nodo.Hijos[1])} )";
            }

            internal string ImprimirArbolPosfijo(Nodo nodo)
            {
                //analiza el conenido de una hoja 
                if (!nodo.Hijos.Any())
                    return nodo.Valor;

                return $"( {ImprimirArbolPosfijo(nodo.Hijos[0])} {ImprimirArbolPosfijo(nodo.Hijos[1])}  {nodo.Valor} ) ";
            }
        }
    }
}
