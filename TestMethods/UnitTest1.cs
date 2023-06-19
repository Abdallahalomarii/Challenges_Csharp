using lab_03_Challanges;
using Microsoft.VisualBasic;

namespace TestMethods
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(50, "25 2 1")]
        [InlineData(50, "25 2 1 50")]
        [InlineData(0, "5 4")]
        [InlineData(1, "")]
        [InlineData(10, "5 2 asdf")]
        [InlineData(1, "ahmad Shaker khaled")]
        public void TestProductNumberMEthodWith4TestCases(int expected, string actual)
        {
            // set the actual input inside the console.readline 
            var ReadConsole = new StringReader(actual);
            Console.SetIn(ReadConsole);

            // act 

            int result = Program.ProductNumbers();

            // Assert

            Assert.Equal(expected, result);

        }


        [Theory]
        [InlineData(0, "4\n0.0\n0.0\n0.0\n0.0")]
        [InlineData(20, "8\n10.40\n8.50\n5.14\n6.85\n11.13\n50.11\n4.47\n70.88")]
        [InlineData(53, "4\n20\n100\n5.0\n90.0")]
        [InlineData(10, "4\n8.5\n14.2\n4.2\n16.0")]
        public void TestAverageMethod(double expected, string actual)
        {
            // Set the actual input inside the Console.ReadLine
            var ReadConsole = new StringReader(actual);
            Console.SetIn(ReadConsole);
            // Act
            double result = Program.AverageRandomNumbers();
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, new int[] { 2, 2, 1, 1, 5, 5, 8, 8, 9, 9 })]
        [InlineData(5, new int[] { 2, 2, 1, 1, 5, 5, 5 })]
        [InlineData(1, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, })]
        [InlineData(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 50, 0 })]
        [InlineData(80, new int[] { 80, 60, 10, 40, 60, 10, 80, 40 })]
        [InlineData(7, new int[] { 17, 7, 85, 7, 64, 20, 7, 95, 64, 7, 17, 85 })]
        public void TestMostFrequentMethod(int expected, int[] input)
        {
            int result = Program.MostTime(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1000, new int[] { 100, 5, 8, 7, 0, 1000, 10, 10 })]
        [InlineData(-1, new int[] { -100, -10, -50, -1, -50, -48, -86, -79 })]
        [InlineData(50, new int[] { 50, 50, 50, 50, 50, 50, 50, 50 })]
        public void MaxValueMethodTest(int expected, int[] maxArray)
        {
            int result = Program.MaxNumber(maxArray);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new string[] { "This : 4", "is : 2", "a : 1" ,"sentance : 8", "about : 5", "important : 9", "things : 6" }, "This is a sentance about important things")]
        [InlineData(new string[] {"Hello : 5", "I'am : 4", "Abdallah : 8" },"Hello I'am Abdallah")]
        public void WordsLengthMethod(string[] expected, string sentence)
        {
            string[] result = Program.WordCounter(sentence);

            Assert.Equal(expected, result);
        }

    }
}