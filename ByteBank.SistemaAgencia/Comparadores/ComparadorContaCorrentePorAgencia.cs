﻿using System.Collections.Generic;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia.Comparadores
{
  public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
  {
    public int Compare(ContaCorrente x, ContaCorrente y)
    {
      if (Equals(x, y))
        return 0;

      if (x == null)
        return 1;

      if (y == null)
        return -1;
      
      return x.Agencia.CompareTo(y.Agencia); // utilizando o método CompareTo

      // if (x.Agencia < y.Agencia)
      //   return -1; // x fica na frente de y
      //
      // if (x.Agencia == y.Agencia)
      //   return 0; // são equivalentes
      //
      // return 1; // y fica na frente de x
    }
  }
}