namespace TDDByExample.Classes
{
  public abstract class Money
  {
    protected int Amount { get; set; }

    public override bool Equals(object obj)
    {
      Money moneyToCompare = (Money)obj;
      return Amount == moneyToCompare.Amount && moneyToCompare.GetType().Equals(GetType());
    }

    public abstract Money Times(int multiplier);
  }
}