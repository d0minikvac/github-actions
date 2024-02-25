namespace string_modifier
{
    public class Program
    {
        public static string CutFirstLetter(string input)
        {
            string newString = "";
            for (int i = 1; i < input.Length; i++)
            {
                newString += input[i];
            }
            return newString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CutFirstLetter("Random"));
        }
    }
}