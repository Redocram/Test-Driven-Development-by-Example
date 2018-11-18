using System;

namespace TDDByExample.Classes
{
  public class Dollar
  {
    public int Amount { get; set; }

    public Dollar(int amount)
    {
      Amount = amount;
    }

    public Dollar Times(int multiplier)
    {
      return new Dollar(Amount * multiplier);
    }

    public override bool Equals(object obj)
    {
      Dollar dollarToCompare = (Dollar)obj;
      return Amount == dollarToCompare.Amount;
    }
  }
}