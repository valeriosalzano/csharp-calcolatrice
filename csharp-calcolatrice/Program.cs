namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test programma per il calcolo assistito.");

            int i1 = 5;
            int i2 = 11;
            double d1 = 2.45;
            double d2 = 5.98;
            float f1 = 3.48f;
            float f2 = 4.82f;

            Console.WriteLine($"Variabili di test: i1:{i1}, i2:{i2}, d1:{d1}, d2:{d2}, f1:{f1}, f2:{f2}.");
            
            Console.WriteLine($"Somma di due numeri interi: {CalcHelper<int>.Sum(i1, i2)}");
            Console.WriteLine($"Somma di due numeri double: {CalcHelper<double>.Sum(d1, d2)}");
            Console.WriteLine($"Somma di due numeri float: {CalcHelper<float>.Sum(f1, f2)}");

            Console.WriteLine($"Differenza tra due numeri interi: {CalcHelper<int>.Difference(i1, i2)}");
            Console.WriteLine($"Differenza tra due numeri double: {CalcHelper<double>.Difference(d1, d2)}");
            Console.WriteLine($"Differenza tra due numeri float: {CalcHelper<float>.Difference(f1, f2)}");

            Console.WriteLine($"Moltiplicazione di due numeri interi: {CalcHelper<int>.Product(i1, i2)}");
            Console.WriteLine($"Moltiplicazione di due numeri double: {CalcHelper<double>.Product(d1, d2)}");
            Console.WriteLine($"Moltiplicazione di due numeri float: {CalcHelper<float>.Product(f1, f2)}");

            Console.WriteLine($"Valore assoluto di un numero intero: {CalcHelper<int>.AbsoluteValue(-i1)}");
            Console.WriteLine($"Valore assoluto di un numero double: {CalcHelper<double>.AbsoluteValue(-d1)}");
            Console.WriteLine($"Valore assoluto di un numero float: {CalcHelper<float>.AbsoluteValue(-f1)}");

            Console.WriteLine($"Minimo tra due numeri interi: {CalcHelper<int>.Min(i1, i2)}");
            Console.WriteLine($"Minimo tra due numeri double: {CalcHelper<double>.Min(d1, d2)}");
            Console.WriteLine($"Minimo tra due numeri float: {CalcHelper<float>.Min(f1, f2)}");

            Console.WriteLine($"Massimo tra due numeri interi: {CalcHelper<int>.Max(i1, i2)}");
            Console.WriteLine($"Massimo tra due numeri double: {CalcHelper<double>.Max(d1, d2)}");
            Console.WriteLine($"Massimo tra due numeri float: {CalcHelper<float>.Max(f1, f2)}");

            Console.WriteLine("\nIl fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?");
            Console.WriteLine("Polimorfismo\n");

            Console.WriteLine("***** BONUS *****\n");

            Console.WriteLine($"Elevamento a potenza 2^3: {CalcHelper<int>.Pow(2, 3)}");
            Console.WriteLine($"Elevamento a potenza 1^n: {CalcHelper<int>.Pow(1, 5)}");
            Console.WriteLine($"Elevamento a potenza n^1: {CalcHelper<int>.Pow(5, 1)}");
            Console.WriteLine($"Elevamento a potenza {i1}^{i2}: {CalcHelper<int>.Pow( i1, i2)}");
            Console.WriteLine($"Elevamento a potenza 0^n: {CalcHelper<int>.Pow(0, 10)}");
            Console.WriteLine($"Elevamento a potenza n^0: {CalcHelper<int>.Pow(-6, 0)}");
            Console.WriteLine($"Elevamento a potenza 0^0: {CalcHelper<int>.Pow(0, 0)}");
            Console.Write($"Elevamento a potenza 0^-n: ");
            try
            {
                Console.WriteLine(CalcHelper<int>.Pow(0, -2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}