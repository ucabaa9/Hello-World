using System;
using System.Linq;


namespace LDC_Code_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Removing duplicates characters
            string replchar = ("AAAc91%cWwWkLq$1ci3_848v3d_K");
            string newString = string.Join("", replchar.ToCharArray().Distinct());
            Console.WriteLine(newString);

            //2. Replacing the $ sign with £ sign
            string newstr = newString.Replace('$', '£');
            Console.WriteLine(newstr);

            //3. Removing  '4' and '_' from the the string
            string newstr1 = String.Join("", newstr.Split('4', '_'));
            Console.WriteLine(newstr1);

            //4. Truncating the length of the string to 15 characters
            const int MaxLength = 15;
            string newstr2 = newstr1;
                if (newstr2.Length > MaxLength)
                    newstr2 = newstr2.Substring(0, MaxLength);
                Console.WriteLine(newstr2);
            Console.Read();

        }
    }
}
