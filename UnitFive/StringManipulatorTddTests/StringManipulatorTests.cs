using StringManipulatorTdd;

namespace StringManipulatorTddTests
{
    public class StringManipulatorTests
    {
        //method name: ConcatenateTwoStrings
        //behavior: ^^^^^

        [Fact]
        public void ConcatenateTwoStrings_ReturnsConcatenation()
        {
            //arrange
            //no arranging is needed

            //act
            var actual = StringManipulator.ConcatenateTwoStrings("Hello", "World");

            //assert
            Assert.Equal("HelloWorld", actual);
        }

        //method name: RemoveAllLetterE
        [Theory]
        [InlineData("Apple", "Appl")]
        [InlineData("Eels are awesome", "ls ar awsom")]
        public void RemoveAllLetterE_ReturnsStringWithoutAnyE(string s, string expected)
        {
            //arrange

            //act
            var actual = StringManipulator.RemoveAllLetterE(s);

            //assert
            Assert.Equal(expected, actual);
        }

    }
}