using AdventOfCode.Puzzles._2024;

namespace AdventOfCode.Tests.Puzzles._2024;

public class DayFourTests
{
    [Theory]
    [InlineData("MAS\nMAS\nMAS", 1)]
    [InlineData("MAM\nMAM\nSAS", 1)]
    public void SolvePartTwo_WithValidInput_ReturnsTheCorrectAnswer(string data, int expextedResult)
    {
        var lines = data.Split("\n").ToList();

        var result = new DayFour().SolvePartTwo(lines);

        Assert.Equal(1, result);
    }
}