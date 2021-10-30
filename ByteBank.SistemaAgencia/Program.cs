using System;
using System.Collections.Generic;
using System.Linq;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {
      var contas = new List<ContaCorrente>()
      {
        new ContaCorrente(987, 987357),
        new ContaCorrente(357, 357687),
        new ContaCorrente(951, 951346),
        new ContaCorrente(458, 458369),
        new ContaCorrente(128, 128765)
      };

      contas.Sort();

      foreach (var conta in contas)
      {
        Console.WriteLine($"Conta: Ag. {conta.Agencia}, Número: {conta.Numero}");
      }
    }

    static void TestSort()
    {
      var idades = new List<int>()
      {
        99, 1, 5, 10, 98, 35, 4, 65, -1
      };

      idades.Sort();

      foreach (var idade in idades)
      {
        Console.WriteLine(idade);
      }

      var nomes = new List<string>()
      {
        "Tiago", "Rakel", "Peter", "Antonio", "Beatriz"
      };

      nomes.Sort();
      foreach (var nome in nomes)
      {
        Console.WriteLine(nome);
      }
    }

    static void ListIdades()
    {
      List<int> idades = new List<int>();

      idades.Add(1);
      idades.Add(5);
      idades.Add(14);
      idades.Add(25);
      idades.Add(38);
      idades.Add(61);

      // ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);

      idades.AdicionarVarios(5, 448, 7898, 4564);

      // idades.Remove(5);

      for (int i = 0; i < idades.Count; i++)
      {
        Console.WriteLine(idades[i]);
      }
    }

    static void TestaListaDeObject()
    {
      ListaDeObject listaDeIdades = new ListaDeObject();

      listaDeIdades.Adicionar(10);
      listaDeIdades.Adicionar(5);
      listaDeIdades.Adicionar(4);
      listaDeIdades.Adicionar("um texto qualquer");
      listaDeIdades.AdicionarVarios(16, 23, 60);

      for (int i = 0; i < listaDeIdades.Tamanho; i++)
      {
        int idade = (int) listaDeIdades[i];
        Console.WriteLine($"Idade no indice {i}: {idade}");
      }
    }

    static int SomarVarios(params int[] numeros)
    {
      int acumulador = 0;
      foreach (int numero in numeros)
      {
        acumulador += numero;
      }

      return acumulador;
    }


    static void TestaListaDeContaCorrente()
    {
      //ListaDeContaCorrente lista = new ListaDeContaCorrente();
      ListaDeContaCorrente lista = new ListaDeContaCorrente();

      ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

      ContaCorrente[] contas = new ContaCorrente[]
      {
        contaDoGui,
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679754)
      };

      lista.AdicionarVarios(contas);

      lista.AdicionarVarios(
        contaDoGui,
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787)
      );

      for (int i = 0; i < lista.Tamanho; i++)
      {
        ContaCorrente itemAtual = lista[i];
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
      }
    }


    static void TestaArrayDeContaCorrente()
    {
      ContaCorrente[] contas = new ContaCorrente[]
      {
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 4456668),
        new ContaCorrente(874, 7781438)
      };

      for (int indice = 0; indice < contas.Length; indice++)
      {
        ContaCorrente contaAtual = contas[indice];
        Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
      }
    }

    static void TestaArrayInt()
    {
      // ARRAY de inteiros, com 5 posições!
      int[] idades = null;
      idades = new int[3];

      idades[0] = 15;
      idades[1] = 28;
      idades[2] = 35;
      //idades[3] = 50;
      //idades[4] = 28;
      //idades[5] = 60;

      Console.WriteLine(idades.Length);

      int acumulador = 0;
      for (int indice = 0; indice < idades.Length; indice++)
      {
        int idade = idades[indice];

        Console.WriteLine($"Acessando o array idades no índice {indice}");
        Console.WriteLine($"Valor de idades[{indice}] = {idade}");

        acumulador += idade;
      }

      int media = acumulador / idades.Length;
      Console.WriteLine($"Média de idades = {media}");
    }
  }
}