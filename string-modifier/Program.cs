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

        public static string CutLastLetter(string input)
        {
            string newString = "";
            for (int i = 0; i < input.Length-1; i++)
            {
                newString += input[i];
            }
            return newString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CutFirstLetter("Elso"));
            Console.WriteLine(CutLastLetter("Utolso"));
        }
    }
}