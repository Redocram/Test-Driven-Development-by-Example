namespace TDDByExample.Classes
{
  public class Money
  {
    protected int amount { get; set; }

    public override bool Equals(object obj)
    {
      Money moneyToCompare = (Money)obj;
      return amount == moneyToCompare.amount;
    }
  }
}