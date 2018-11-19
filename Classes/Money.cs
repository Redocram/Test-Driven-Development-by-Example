using System;

namespace TDDByExample.Classes
{
  public class Money
  {
    protected int Amount { get; set; }

    public Dollar Dollar(int amount)
    {
      return new Dollar(amount);
    }

    public override bool Equals(object obj)
    {
      Money moneyToCompare = (Money)obj;
      return Amount == moneyToCompare.Amount && moneyToCompare.GetType().Equals(GetType());
    }

    public Money Times(int multiplier)
    {
      throw new NotImplementedException();
    }
  }
}