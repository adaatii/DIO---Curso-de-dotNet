﻿using System.Text;

var sb = new StringBuilder();
sb.AppendLine("Texto na primeira linha para ler");
sb.AppendLine("segunda linha");
sb.AppendLine("e o fim");

using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;


do
{
    Console.WriteLine(sr.ReadLine());
} while (sr.Peek() >= 0);


/* do
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.Write(string.Join("", buffer));

} while (tamanho >= buffer.Length); */

Console.WriteLine("Pressione enter para finalizar");
Console.ReadLine();

