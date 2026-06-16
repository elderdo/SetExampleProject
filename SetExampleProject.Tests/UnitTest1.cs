namespace SetExampleProject.Tests;

public class SetComparerTests
{
    [Fact]
    public void AreSetsEquivalent_ReturnsTrue_WhenUniqueElementsMatch()
    {
        int[] first = new[] { 1, 2, 3, 4 };
        int[] second = new[] { 4, 2, 4, 3, 1, 3 };

        bool result = SetComparer.AreSetsEquivalent(first, second);

        Assert.True(result);
    }

    [Fact]
    public void AreSetsEquivalent_ReturnsFalse_WhenElementsDiffer()
    {
        int[] first = new[] { 1, 2, 3, 4 };
        int[] second = new[] { 1, 2, 3, 5 };

        bool result = SetComparer.AreSetsEquivalent(first, second);

        Assert.False(result);
    }

    [Fact]
    public void AreSetsEquivalent_Throws_WhenFirstIsNull()
    {
        int[] second = new[] { 1, 2, 3 };

        Assert.Throws<ArgumentNullException>(() => SetComparer.AreSetsEquivalent(null!, second));
    }

    [Fact]
    public void AreSetsEquivalent_Throws_WhenSecondIsNull()
    {
        int[] first = new[] { 1, 2, 3 };

        Assert.Throws<ArgumentNullException>(() => SetComparer.AreSetsEquivalent(first, null!));
    }
}
