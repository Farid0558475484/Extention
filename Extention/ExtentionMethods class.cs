using System.Text;

namespace Extention
{
    public static class ExtentionMethods_class
    {
        static public bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;


        }

        static public bool IsEven(this int num1)
        {
            if (num1 % 2 == 0)

            {
                return true;
            }
            return false;
        }
        static public bool IsContainsDigit(this string character)
        {

            for (int i = 0; i < character.Length; i++)
            {
                if (char.IsDigit(character[i]))
                {
                    return true;
                }
                
            }
            return false;
        }

        static public string ToCapitalize(this string temp)
        {

            StringBuilder sb1 = new StringBuilder();

            sb1.Append(char.ToUpper(temp[0]));
            sb1.Append(temp.Substring(1).ToLower());
            return sb1.ToString();
            
        }
    }
}

