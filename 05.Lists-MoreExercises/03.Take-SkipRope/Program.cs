namespace _03.Take_SkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<int> digits = new List<int>();
            List<char> characters = new List<char>();

            IsDigitOrChar(text, digits, characters);

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            FillTakeSkipList(digits, takeList, skipList);
            string result = CreateResultString(characters, takeList, skipList);

            Console.WriteLine(result);




            static void IsDigitOrChar(string text, List<int> digits, List<char> characters)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= 48 && text[i] <= 57) //is a digit
                    {
                        digits.Add(int.Parse(text[i].ToString()));
                    }
                    else //is a char
                    {
                        characters.Add(text[i]);
                    }
                }
            }
        }

      static string CreateResultString(List<char> characters, List<int> takeList, List<int> skipList)
        {
            string result = "";
            int index = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];

                if (index + take > characters.Count)
                {
                    take = characters.Count - index;
                }

                for (int j = 0; j < take; j++)
                {
                    result += characters[index + j];
                }

                index += take + skip;

            }

            return result;
        }

        static void FillTakeSkipList(List<int> digits, List<int> takeList, List<int> skipList)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }
        }
    }
}