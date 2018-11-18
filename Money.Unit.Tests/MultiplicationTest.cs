using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using TDDByExample.Classes;

namespace Money.Unit.Tests
{
  // TODO:
  // $5 + 10 CHF =  $10 if CHF:USD is 2:1
  // Make Dollar.Amount private
  // Money rounding?
  // HashCode()
  // Equal null
  // Equal object
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
      product1.Should().Be(new Dollar(10));
      product2.Should().Be(new Dollar(15));
    }

    [Test]
    public void Two_Istances_Of_Dollar_With_The_Same_Amount_Should_Be_Equal()
    {
      // ARRANGE

      // ACT

      // ASSERT
      new Dollar(5).Should().Be(new Dollar(5));
    }

    [Test]
    public void Two_Istances_Of_Dollar_With_A_Different_Amount_Should_Not_Be_Equal()
    {
      // ARRANGE

      // ACT

      // ASSERT
      new Dollar(5).Should().NotBe(new Dollar(6));
    }
  }
}