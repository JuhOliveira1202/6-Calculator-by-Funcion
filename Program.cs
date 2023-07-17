// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Calculadora()
    {
        int valor, soma, min, max, contador;
        float media;

        min = 0;
        max = 0;

        Console.WriteLine("Insira os números: ");
        contador = 0;
        soma = 0;

        do
        {
            valor = Convert.ToInt32(Console.ReadLine());

            if (contador == 0)
            {
                min = valor;
                max = valor;
            }

            if (valor >= 0)
            {
                contador = contador + 1;
                soma = soma + valor;

                if (valor > max)
                {
                    max = valor;
                }
                else if (valor < min)
                {
                    min = valor;
                }
            }
        } while (valor >= 0);

        if (contador > 0)
        {
            media = soma / contador;
        }
        else
        {
            media = 0;
        }

        Console.WriteLine("Soma = " + soma);
        Console.WriteLine("Média = " + media);
        Console.WriteLine("Máximo = " + max);
        Console.WriteLine("Mínimo = " + min);
    }
    public static void Main(string[] args)
    {
        Calculadora();
    }
}
