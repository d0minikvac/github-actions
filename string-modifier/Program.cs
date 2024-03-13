namespace string_modifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringModifier sm = new StringModifier();
            string input = "Hello";

            string result = sm.CutFirstLetter(input);
            Console.WriteLine(result);

            string result2 = sm.CutLastLetter(input);
            Console.WriteLine(result2);


        }
    }
}