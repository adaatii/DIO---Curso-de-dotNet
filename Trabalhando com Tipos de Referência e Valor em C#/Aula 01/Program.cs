﻿using System;
using static System.Console;


public class Program
{

    static void Demo6()
    {
        int[] numeros = new int[] { 0, 2, 4, 6, 8 };
        WriteLine($"Digite o numero que gostaria de encontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);


        if (idxEncontrado >= 0)
        {
            WriteLine($"O numero digitado esta na posição {idxEncontrado}");
        }
        else
        {
            WriteLine($"O numero digitado não foi encontrado");
        }

    }
    static void Demo5()
    {
        int[] pares = new int[] { 0, 2, 4, 6, 8 };

        MudarParaImpar(pares);
        WriteLine($"Os impares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Lucas";

        TrocarNome(nome, "Pedro");
        WriteLine($@"O novo nome é {nome}");

    }
    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "1234",
            Idade = 29,
            Nome = "Lucas"
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "João");

        WriteLine($@"
       Nome da p1 {p1.Nome}
       Nome da p2 {p2.Nome}
       ");
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Lucas";
        p1.Idade = 29;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "José");

        WriteLine($@"
       O nome de p1 é {p1.Nome}
       O nome de p2 é {p2.Nome}
       ");
    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variavel a é {a}");
    }

    static int Adicionar20(int a)
    {
        return a + 20;
    }
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }
    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }
    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
            {
                return i;

            }
        }
        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if (item.Nome == pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        List<Pessoa> pessoas =new List<Pessoa>()
        {
            new Pessoa(){Nome = "Lucas"},
            new Pessoa(){Nome = "Mabi"},
            new Pessoa(){Nome = "João"},
            new Pessoa(){Nome = "José"},
            new Pessoa(){Nome = "Thiago"},
        };

        WriteLine("Digite a pessoa que deseja localizar");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if (encontrado)
        {
            WriteLine("Pessoa localizada");
        }
        else
        {
            WriteLine("Pessoa não localizada");
        }
    }
}
