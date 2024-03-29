﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class MaHoa
    {
        public static string MaHoaDuLieu(string inputStr)
        {
            int len = inputStr.Length;

            int sum = 10;

            char[] encryptedChars = new char[len];

            for (int i = 0; i < len; i++)

            {

                encryptedChars[i] = (char)((int)inputStr[i] + sum);

            }

            char[] newNameStr = new char[len];

            for (int i = 0; i < len; i++)

            { // reverse the name

                newNameStr[i] = encryptedChars[len - 1 - i];

            }

            for (int i = 0; i < len; i++)

            { // reverse the name

                encryptedChars[i] = newNameStr[i];

            }



            return String.Intern(new String(encryptedChars));
        }
        public static string GiaiMaDuLieu(string inputStr)
        {
            int len = inputStr.Length;

            char[] decryptedChars = new char[len];

            for (int i = 0; i < len; i++)

            {
                decryptedChars[i] = (char)((int)inputStr[i] - 10);
            }

            char[] newNameStr = new char[len];

            for (int i = 0; i < len; i++)

            { // reverse the name

                newNameStr[i] = decryptedChars[len - 1 - i];

            }

            for (int i = 0; i < len; i++)

            { // reverse the name

                decryptedChars[i] = newNameStr[i];
            }
            return String.Intern(new String(decryptedChars));
        }
        public static string BuildByteArray(string str)

        {
            char ch;

            StringBuilder buf = new StringBuilder("bytearray(");

            for (int i = 0; i < str.Length; i++)

            {

                ch = str[i];

                if ((ch & 0xFF) >= 16)

                    buf.Append(" ");

                else

                    buf.Append(" 0");

                buf.Append((ch & 0xFF).ToString("X"));

                if ((ch >> 8) > 16)

                    buf.Append(" ");

                else

                    buf.Append(" 0");

                buf.Append((ch >> 8).ToString("X"));
            }

            buf.Append(")");
            return buf.ToString();
        }
    }
}
