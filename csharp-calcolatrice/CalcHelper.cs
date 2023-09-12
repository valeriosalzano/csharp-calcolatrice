using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace csharp_calcolatrice
{
    public static class CalcHelper<T> where T : INumber<T>, IComparable<T>
    {
        /*
        //Somma di due numeri interi
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        //Somma di due numeri double
        public static double Sum(double n1, double n2)
        {
            return n1 + n2;
        }
        //Differenza tra due numeri interi
        public static int Difference(int n1, int n2)
        {
            return n1 - n2;
        }
        //Differenza tra due numeri double
        public static double Difference(double n1, double n2)
        {
            return n1 - n2;
        }
        //Moltiplicazione di due numeri interi
        public static int Product(int n1, int n2)
        {
            return n1 * n2;
        }
        //Moltiplicazione di due numeri double
        public static double Product(double n1, double n2)
        {
            return n1 * n2;
        }
        //Valore assoluto di un numero intero
        public static int AbsoluteValue(int n)
        {
            return (n < 0) ? - n : n;
        }
        //Valore assoluto di un numero double
        public static double AbsoluteValue(double n)
        {
            return (n < 0) ? -n : n;
        }
        //Minimo tra due numeri interi
        public static int Min(int n1, int n2)
        {
            return (n1 <= n2) ? n1 : n2;
        }
        //Minimo tra due numeri double
        public static double Min(double n1, double n2)
        {
            return (n1 <= n2) ? n1 : n2;
        }
        //Massimo tra due numeri interi
        public static int Max(int n1, int n2)
        {
            return (n1 >= n2) ? n1 : n2;
        }
        //Massimo tra due numeri double
        public static double Max(double n1, double n2)
        {
            return (n1 >= n2) ? n1 : n2;
        }
        */
        // ***** BONUS *****

        public static int Pow(int baseNum, int expNum)
        {
            if (expNum < 0)
            {
                if (baseNum == 0)
                    throw new Exception("Dividing by zero");
                else
                    return 1/(Pow( baseNum, -expNum));
            }
            else
            {
                if (expNum == 0)
                    return 1;
                else
                {
                    for (int i = 0; i < expNum; i++)
                    {
                        baseNum *= baseNum;
                    }
                    return baseNum;
                }
            }
        }

        // ***** SUPER SUPER BONUS *****

        //Somma di due numeri
        public static T Sum(T n1, T n2)
        {
            return n1 + n2;
        }
        //Differenza tra due numeri
        public static T Difference(T n1, T n2)
        {
            return n1 - n2;
        }
        //Moltiplicazione di due numeri
        public static T Product(T n1, T n2)
        {
            return n1 * n2;
        }
        //Valore assoluto di un numero
        public static T AbsoluteValue(T n)
        {
            return (n < -n) ? -n : n;
        }
        //Minimo tra due numeri
        public static T Min(T n1, T n2)
        {
            return (n1 <= n2) ? n1 : n2;
        }
        //Massimo tra due numeri
        public static T Max(T n1, T n2)
        {
            return (n1 >= n2) ? n1 : n2;
        }

    }
}
