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
      Dollar value = five.Times(2);

      // ASSERT
      value.Amount.Should().Be(10);
    }

    [Test]
    public void TestMultiplication()
    {
      // ARRANGE
      Dollar five = new Dollar(5);

      // ACT
      Dollar product1 = five.Times(2);
      Dollar product2 = five.Times(3);

      // ASSERT
      product1.Amount.Should().Be(10);
      product2.Amount.Should().Be(15);
    }
  }
}