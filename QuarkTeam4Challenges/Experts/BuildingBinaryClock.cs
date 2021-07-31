using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Experts
{
    /* https://edabit.com/challenge/DZL7PpHQyPvkYiyDL
     * A binary clock displays the time of day in binary format. 
     * Modern binary clocks have six columns of lights; two for each of the hours, minutes and seconds. 
     * The photo below shows a binary clock displaying the time "12:15:45":
     */
    public class BuildingBinaryClock
    {
        public static string[] BinaryClock(string time) {
            string[] resultado = { " 0 0 0", " 00000", "000000", "000000" };
            //string[] resultado = new string[4];
            string[] arrayTiempo = time.Split(':');
            int horas = Convert.ToInt32(arrayTiempo[0]);
            int minutos = Convert.ToInt32(arrayTiempo[1]);
            int segundos = Convert.ToInt32(arrayTiempo[2]);
            string binaryHoursDec = ParseToBinary(horas/10,2), binaryHoursUnit = ParseToBinary(horas % 10,4),
                binaryMinutesDec = ParseToBinary(minutos/10,3), binaryMinutesUnit = ParseToBinary(minutos % 10,4),
                binarySecondsDec = ParseToBinary(segundos/10,3), binarySecondsUnit = ParseToBinary(segundos % 10,4);

            resultado[0] = $" {binaryHoursUnit[0]} {binaryMinutesUnit[0]} {binarySecondsUnit[0]}";
            resultado[1] = $" {binaryHoursUnit[1]}{binaryMinutesDec[0]}{binaryMinutesUnit[1]}{binarySecondsDec[0]}{binarySecondsUnit[1]}";
            resultado[2] = $"{binaryHoursDec[0]}{binaryHoursUnit[2]}{binaryMinutesDec[1]}{binaryMinutesUnit[2]}{binarySecondsDec[1]}{binarySecondsUnit[2]}";
            resultado[3] = $"{binaryHoursDec[1]}{binaryHoursUnit[3]}{binaryMinutesDec[2]}{binaryMinutesUnit[3]}{binarySecondsDec[2]}{binarySecondsUnit[3]}";

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            return resultado;
        }

        public static string ParseToBinary(int num, int digits) {
            string result = string.Empty;
            for (int i = 0; num > 0; i++) {
                result = num % 2 + result;
                num = num / 2;
            }
            result = result.PadLeft(digits, '0');
            return result;
        }

    }
}

//Estimado: 30 minutos
//Reales: 40 minutos
//Integrantes: Equipo 4
