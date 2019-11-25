using System;
using Xunit;
using NumberWorder;

namespace NumberWorder.Tests
{

    public class NumberWordValidation
    {
        [Theory]
        [InlineData("123", "OneTwoThree")]
        [InlineData("345", "ThreeFourFive")]
        [InlineData("7966", "SevenNineSixSix")]
        public void ConvertNumberToWord_InLineInput_OneTwoThree(string inputOne, string expected)
        {
            // Act
            var result = ConverterHelper.ConvertNumberToWord(inputOne);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("argumentAsString")]
        [InlineData("FourFiveSix897")]
        [InlineData("Four76^)(*")]
        public void ConvertNumberToWord_StringInput_FormatException(string input)
        {
            // Assert
            Assert.Throws<FormatException>(() => ConverterHelper.ConvertNumberToWord(input));
        }
    }
}
