using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.VeryDificult
{
    //Create a function that returns the simplified version of a fraction.
    public class SimplifiedFractions
    {
        public string Simplify(string str)
        {
            string[] parts = str.Split('/');
            int quotient, divider;
            if (parts.Length < 2)
            {
                throw new Exception("No es una fracción");
            }
            else if (!int.TryParse(parts[0], out quotient))
            {
                throw new Exception("Cociente no es un numero");
            }
            else if (!int.TryParse(parts[1], out divider))
            {
                throw new Exception("Divisor no es un numero");
            }
            else
            {
                int mcd = MCD(quotient, divider);
                while (mcd > 1) {
                    quotient /= mcd;
                    divider /= mcd;
                    mcd = MCD(quotient, divider);
                }
                if (divider == 1)
                    return $"{quotient}";
                else
                    return $"{quotient}/{divider}";
            }
        }

        private int MCD(int num1, int num2)
        {
            int min = Math.Min(num1, num2);
            int mcd = 0;

            for (int i = min; i >= 1; i--) {
                if (num1 % i == 0 && num2 % i == 0) {
                    mcd = i;
                    break;
                }
            }
            return mcd;
        }   

    }
}

 //Estimado: 15 minutos
 //Reales: 20 minutos
 //Integrantes: Equipo 4