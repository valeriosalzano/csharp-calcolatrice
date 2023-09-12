﻿namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test programma per il calcolo assistito.");

            int a = 5;
            int b = 11;
            double c = 2.45d;
            double d = 5.98;

            Console.WriteLine($"Variabili di test: a:{a}, b:{b}, c:{c}, d:{d}.");
            Console.WriteLine($"Somma di due numeri interi: {CalcHelper.Sum(a,b)}");
            Console.WriteLine($"Somma di due numeri double: {CalcHelper.Sum(c, d)}");
            Console.WriteLine($"Differenza tra due numeri interi: {CalcHelper.Difference(a,b)}");
            Console.WriteLine($"Differenza tra due numeri double: {CalcHelper.Difference(c,d)}");
            Console.WriteLine($"Moltiplicazione di due numeri interi: {CalcHelper.Product(a,b)}");
            Console.WriteLine($"Moltiplicazione di due numeri double: {CalcHelper.Product(c,d)}");
            Console.WriteLine($"Valore assoluto di un numero intero: {CalcHelper.AbsoluteValue(-a)}");
            Console.WriteLine($"Valore assoluto di un numero double: {CalcHelper.AbsoluteValue(-c)}");
            Console.WriteLine($"Minimo tra due numeri interi: {CalcHelper.Min(a,b)}");
            Console.WriteLine($"Minimo tra due numeri double: {CalcHelper.Min(c,d)}");
            Console.WriteLine($"Massimo tra due numeri interi: {CalcHelper.Max(a,b)}");
            Console.WriteLine($"Massimo tra due numeri double: {CalcHelper.Max(c,d)}");

            Console.WriteLine("\nIl fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?");
            Console.WriteLine("MONOROTAIA!... ops...Polimorfismo\n");

            Console.WriteLine("***** BONUS *****\n");
            Console.WriteLine($"Elevamento a potenza: {CalcHelper.Pow(a,b)}");
            Console.WriteLine($"Elevamento a potenza 0^n: {CalcHelper.Pow(0, 10)}");
            Console.WriteLine($"Elevamento a potenza n^0: {CalcHelper.Pow(-6, 0)}");
            Console.WriteLine($"Elevamento a potenza 0^0: {CalcHelper.Pow(0, 0)}");
            try
            {
                Console.WriteLine($"Elevamento a potenza 0^-n: {CalcHelper.Pow(0, -2)}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Elevamento a potenza 0^-n: {e.Message}");
            }
            
        }
    }
}