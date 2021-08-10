using System;
using System.Collections.Generic;
using System.Text;

namespace QuarkTeam4Challenges.Difficult
{

    /*
     Create a function that determines whether a string is a valid hex code.
     A hex code must begin with a pound key # and is exactly 6 characters in length. 
     Each character must be a digit from 0-9 or an alphabetic character from A-F. 
     All alphabetic characters may be uppercase or lowercase.
    - Tiene # al inicio
    - Tiene largo de 6 caracteres
    - Los caracteres son entre 0-9 
    - Los caracteres son letras entre A-F

    ASCII 
    0-9 48-57
    A-F 65-70
    a-f 97-102
     */

    public class HexCode
    {
        public bool IsValidHexCode(string str)
        {
            if(str[0] != '#' || str.Length != 7)
            {
                return false;
            }

            char currentChar;
            for (int i = 1; i < str.Length; i++) 
            {
                currentChar = str[i];
                if (!char.IsLetterOrDigit(currentChar) || currentChar > 70 && currentChar < 97 || currentChar > 102)
                   return false;
            }

            return true;
        }

    }

    // Tiempo estimado: 30 minutes
    // Tiempo real: 
}