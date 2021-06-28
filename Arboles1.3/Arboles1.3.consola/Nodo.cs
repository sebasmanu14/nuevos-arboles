using System.Collections.Generic;

namespace Arboles1._3.consola
{
    partial class Program
    {
        class Nodo 
        {
            public int Id { get; set; }
            public string Valor { get; set; }
            public List<Nodo> Hijos { get; set; } = new List<Nodo>();
        }
    }
}
