using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using TDDByExample.Classes;

namespace Money.Unit.Tests
{
  [TestFixture]
  [ExcludeFromCodeCoverage]
  public class MultiplicationTest
  {
    [Test]
    public void Multiplication_Should_Return_A_Valid_Value()
    {
      // ARRANGE
      Dollar five = new Dollar(5);

      // ACT
      five.Times(2);

      // ASSERT
      five.amount.Should().Be(10);
    }
  }
}