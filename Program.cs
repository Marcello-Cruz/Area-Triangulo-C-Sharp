﻿using system
namespace areatrianguloret
class program
static void Main(string{} args)
double medidaBase, medidaAltura, medidaArea;
Console.Write("Qual é a base..:");
medidaBase = Convert.ToDouble(Console.Readline());
Console.Write("Qual é a altura: ");
medidaAltura = ConvertToDouble(Console.Readline());
medidaArea = (medidaBase * medidaAltura) /2;
Console.Writeline($"Área do Triângulo:{medidaArea}");

