using string_modifier;

namespace TestStrings
{
    public class TestStrings
    {
        [Fact]
        public void CutFirstLetter_ShouldCutFirstLetter()
        {
            string input = "Hello";
            string expected = "ello";

            StringModifier sm = new StringModifier();
            string actual = sm.CutFirstLetter(input);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CutLastLetter_ShouldCutLastLetter()
        {
            string input = "Hello";
            string expected = "Hell";

            StringModifier sm = new StringModifier();
            string actual = sm.CutLastLetter(input);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void NotFaultyTest()
        {
            string input = "Hello";
            string expected = "Hello";

            StringModifier sm = new StringModifier();
            string actual = sm.CutLastLetter(input);


            Assert.Equal(expected, actual);
        }
    }
}