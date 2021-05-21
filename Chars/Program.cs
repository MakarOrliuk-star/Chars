using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int example = GetCharsCount("abcdefabcdef", new char[] { 'a', 'e' });
            Console.WriteLine(example);

            int example2 = GetCharsCount("abcdefghijklmnabcdefghijklmn", new char[] { 'a', 'c', 'd', 'l', 'm' }, 1, 16, 7);
            Console.WriteLine(example2);
        }
        public static int GetCharsCount(string str, char[] chars)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == str[i])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars is null)
            {
                throw new ArgumentNullException(nameof(chars));
            }
            else if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            else if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            else if (endIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }
            else if (endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }
            else if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            else if (limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit));
            }

            int count = 0;
            int currentElement = 0;
            int currentChar = startIndex;
            do
            {
                do
                {
                    if (chars[currentElement] == str[currentChar] && count < limit)
                    {
                        count++;
                    }

                    currentElement++;
                }
                while (currentElement < chars.Length);

                currentElement = 0;
                currentChar++;
            }
            while (currentChar <= endIndex);

            return count;
        }
    }
}
