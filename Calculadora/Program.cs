﻿using Calculadora.Services;

CalculadoraImp c = new();

int num1 = 5;
int num2 = 23;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1,num2)}");