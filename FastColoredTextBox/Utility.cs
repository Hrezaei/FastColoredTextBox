using System;
using System.Collections.Generic;
using System.Text;

namespace FastColoredTextBoxNS
{
    class Utility
    {

        public static String PersianNumber(int n)
        {
            String result = "";
            System.Char[] adad = { '٠', '١', '٢', '٣', '٤', '٥', '٦', '٧', '٨', '٩' };
            Byte[] bytes = { 217, 160 };
            int m = n.ToString().Length;
            System.Text.Decoder utf8Decoder = System.Text.UTF8Encoding.UTF8.GetDecoder();
            System.Char[] cTransChar = { ' ' };
            for (int i = 1; i <= m; i++)
            {
                int y = Convert.ToInt16(n % 10);
                result = adad[y] + result;
                n = (n - y) / 10;
            }

            return result;
        }
    }

}


