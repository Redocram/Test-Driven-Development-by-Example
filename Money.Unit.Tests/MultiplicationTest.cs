using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using TDDByExample.Classes;

namespace Money.Unit.Tests
{
  // TODO:
  // $5 + 10 CHF =  $10 if CHF:USD is 2:1
  // Done. Make Dollar.Amount private
  // Money rounding?
  // HashCode()
  // Equal null
  // Equal object
  // Done. 5 CHF * 2 = 10 CHF
  // Dollar/Franc duplication
  // Common equals
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
      value.Should().NotBeNull()
        .And.Be(new Dollar(10));
    }

    [Test]
    public void TestDollarMultiplication()
    {
      // ARRANGE
      Dollar five = new Dollar(5);

      // ACT & ASSERT
      five.Times(2).Should().Be(new Dollar(10));
      five.Times(3).Should().Be(new Dollar(15));
    }

    [Test]
    public void Two_Istances_Of_Dollar_With_The_Same_Amount_Should_Be_Equal()
    {
      // ARRANGE

      // ACT & ASSERT
      new Dollar(5).Should().Be(new Dollar(5));
    }

    [Test]
    public void Two_Istances_Of_Dollar_With_A_Different_Amount_Should_Not_Be_Equal()
    {
      // ARRANGE

      // ACT & ASSERT
      new Dollar(5).Should().NotBe(new Dollar(6));
    }

    [Test]
    public void TestFrancMultiplication()
    {
      // ARRANGE
      Franc five = new Franc(5);

      // ACT & ASSERT
      five.Times(2).Should().Be(new Franc(10));
      five.Times(3).Should().Be(new Franc(15));
    }
  }
}