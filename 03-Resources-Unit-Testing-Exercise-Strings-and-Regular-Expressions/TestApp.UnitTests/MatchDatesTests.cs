﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31.Dec.2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "312.Dece.2022";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
        [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
            // Arrange
            string input = "31.Dec.2022, 31.Dec.2022, 23.Jun.2011";
            string expected = "Day: 31, Month: Dec, Year: 2022";

            // Act
            string result = MatchDates.Match(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        string input = null;
        
        // Act
        
        Assert.That(() => MatchDates.Match(input),
            Throws.ArgumentException);
    }
}
