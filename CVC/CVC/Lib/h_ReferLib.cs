using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CVC.Lib
{
    class h_ReferLib
    {
        public static char[] Reverse(string text)
        {
            if (text == null) return null;

            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return array;
        }

        public static string HexStrToBinStr(string HexStr)
        {
            string BinStr = null;
            for (int i = 0; i < HexStr.Length; i++)
            {
                switch (HexStr[i])
                {
                    case '0': BinStr = BinStr + "0000"; break;
                    case '1': BinStr = BinStr + "0001"; break;
                    case '2': BinStr = BinStr + "0010"; break;
                    case '3': BinStr = BinStr + "0011"; break;
                    case '4': BinStr = BinStr + "0100"; break;
                    case '5': BinStr = BinStr + "0101"; break;
                    case '6': BinStr = BinStr + "0110"; break;
                    case '7': BinStr = BinStr + "0111"; break;
                    case '8': BinStr = BinStr + "1000"; break;
                    case '9': BinStr = BinStr + "1001"; break;
                    case 'a': 
                    case 'A': BinStr = BinStr + "1010"; break;
                    case 'b':
                    case 'B': BinStr = BinStr + "1011"; break;
                    case 'c': 
                    case 'C': BinStr = BinStr + "1100"; break;
                    case 'd':
                    case 'D': BinStr = BinStr + "1101"; break;
                    case 'e':
                    case 'E': BinStr = BinStr + "1110"; break;
                    case 'f':
                    case 'F': BinStr = BinStr + "1111"; break;
                }
            }
            return BinStr;
        }
    }
}

