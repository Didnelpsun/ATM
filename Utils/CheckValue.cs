
namespace ATM
{
    partial class Utils
    {
        public static bool CheckValidChar(string str, params char[] exchars)
        {
            for (int i = 0; i < str.Length;)
            {
                if (!IsDefaultValidChar(str[i]))
                {
                    int j;
                    for (j = 0; j < exchars.Length;)
                    {
                        if (str[i].CompareTo(exchars[j]) == 0)
                        {
                            i++;
                            break;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    if (j == exchars.Length)
                    {
                        return false;
                    }
                }
                else
                {
                    i++;
                }
            }
            return true;
        }

        public static int CharToAsc(string str)
        {
            return CharToAsc(str.ToCharArray()[0]);
        }

        public static int CharToAsc(char ch)
        {
            return ch;
        }

        public static bool IsDefaultValidChar(string str)
        {
            return IsDefaultValidChar(str.ToCharArray()[0]);
        }

        public static bool IsDefaultValidChar(char ch)
        {
            if ((ch > 47 && ch < 58) || (ch > 64 && ch < 91) || (ch > 96 && ch < 123))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
