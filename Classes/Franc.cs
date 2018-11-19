namespace TDDByExample.Classes
{
  public class Franc : Money
  {
    public Franc(int amount)
    {
      this.amount = amount;
    }

    public Franc Times(int multiplier)
    {
      return new Franc(amount * multiplier);
    }

    public override bool Equals(object obj)
    {
      Franc francToCompare = (Franc)obj;
      return amount == francToCompare.amount;
    }
  }
}