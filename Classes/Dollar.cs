namespace TDDByExample.Classes
{
  public class Dollar
  {
    private int amount { get; set; }

    public Dollar(int amount)
    {
      this.amount = amount;
    }

    public Dollar Times(int multiplier)
    {
      return new Dollar(amount * multiplier);
    }

    public override bool Equals(object obj)
    {
      Dollar dollarToCompare = (Dollar)obj;
      return amount == dollarToCompare.amount;
    }
  }
}