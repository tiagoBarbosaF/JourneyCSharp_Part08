using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> listaDeItems, params T[] itens)
        {
            foreach(T item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
