using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
  public static class ListExtensoes
  {
    public static void AdicionarVarios<T>(this List<T> lista, params T[] items)
    {
      foreach (T item in items)
      {
        lista.Add(item);
      }
    }
  }
}