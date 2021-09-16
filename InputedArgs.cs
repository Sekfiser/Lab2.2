using System.Linq;

namespace Lab1._2
{
    /// <summary>
    /// Contains command line string array and array of integer digits that was found in command line array.
    /// </summary>
    public class InputedArgs : IArray
    {
        public string[] Args { get; set; }
        public int[] Digits { get; set; }

        /// <summary>
        /// Create new array of integer digits from string array.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public InputedArgs(string[] args)
        {
            Args = args;
            Digits = new int[Args.Length];

        }
        public int Sum()
        {
            int i = 0;
            foreach (string element in Args)
            {
                if (int.TryParse(element, out Digits[i]))
                { i++; }
                else
                {
                    Digits[i] = 0;
                    i++;
                }
            }
            return Digits.Sum();
        }

        public int Multi()
        {
            int i = 0;
            foreach (string element in Args)
            {
                if (int.TryParse(element, out Digits[i]))
                {
                    i++;
                }
                else 
                {
                    Digits[i] = 1;
                    i++;
                }
            }
            return Digits.Aggregate((x, y) => x * y);
        }
    }
}
