using Xunit;

public class ProgramTests
{
    [Fact]
    public void CountDivisors_InputIs1_Returns1()
    {
        // Arrange
        long x = 1;

        // Act
        int result = Program.CountDivisors(x);

        // Assert
        Assert.Equal(1, result); // Дільники: 1
    }

    [Fact]
    public void CountDivisors_InputIs12_Returns6()
    {
        // Arrange
        long x = 12;

        // Act
        int result = Program.CountDivisors(x);

        // Assert
        Assert.Equal(6, result); // Дільники: 1, 2, 3, 4, 6, 12
    }

    [Fact]
    public void CountDivisors_InputIs239_Returns2()
    {
        // Arrange
        long x = 239;

        // Act
        int result = Program.CountDivisors(x);

        // Assert
        Assert.Equal(2, result); // Дільники: 1, 239 (просте число)
    }

    [Fact]
    public void CountDivisors_InputIs100_Returns9()
    {
        // Arrange
        long x = 100;

        // Act
        int result = Program.CountDivisors(x);

        // Assert
        Assert.Equal(9, result); // Дільники: 1, 2, 4, 5, 10, 20, 25, 50, 100
    }

    [Fact]
    public void CountDivisors_InputIs997_Returns2()
    {
        // Arrange
        long x = 997;

        // Act
        int result = Program.CountDivisors(x);

        // Assert
        Assert.Equal(2, result); // Дільники: 1, 997 (просте число)
    }
}
