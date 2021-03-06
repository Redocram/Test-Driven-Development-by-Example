﻿using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using TDDByExample.Classes;
using MoneyTDD = TDDByExample.Classes.Money;

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
  // Done. Francs != Dollar
  // Currency
  [TestFixture]
  [ExcludeFromCodeCoverage]
  public class MultiplicationTest
  {
    [Test]
    public void Multiplication_Should_Return_A_Valid_Value()

    {
      // ARRANGE
      MoneyTDD money = new MoneyTDD();

      // ACT
      Dollar five = money.Dollar(5);

      // ASSERT
      five.Should().NotBeNull()
        .And.Be(money.Dollar(5));
    }

    [Test]
    public void TestDollarMultiplication()
    {
      // ARRANGE
      MoneyTDD money = new MoneyTDD();
      MoneyTDD five = money.Dollar(5);

      // ACT & ASSERT
      five.Times(2).Should().Be(money.Dollar(10));
      five.Times(3).Should().Be(money.Dollar(15));
    }

    [Test]
    public void Two_Istances_Of_Dollar_With_The_Same_Amount_Should_Be_Equal()
    {
      // ARRANGE & ACT & ASSERT
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

    [Test]
    public void Two_Istances_Of_Franc_With_The_Same_Amount_Should_Be_Equal()
    {
      // ARRANGE & ACT & ASSERT
      new Franc(5).Should().Be(new Franc(5));
    }

    [Test]
    public void Two_Istances_Of_Franc_With_A_Different_Amount_Should_Not_Be_Equal()
    {
      // ARRANGE ACT & ASSERT
      new Dollar(5).Should().NotBe(new Dollar(6));
    }

    [Test]
    public void Should_Be_POssible_To_Convert_Franc_Into_Dollar()
    {
      // ARRANGE ACT & ASSERT
      new Franc(5).Should().NotBe(new Dollar(5));
    }

    [Test]
    public void Money_dollar_Method_Should_Return_a_Instance_Of_Dollars()
    {
      // ARRANGE
      MoneyTDD money = new MoneyTDD();

      // ACT
      Dollar five = money.Dollar(5);

      // ASSERT
      five.Times(2).Should().Be(new Dollar(10));
      five.Times(3).Should().Be(new Dollar(15));
    }
  }
}