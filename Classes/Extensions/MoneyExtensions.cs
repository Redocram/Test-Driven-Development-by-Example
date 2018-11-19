namespace TDDByExample.Classes.Extensions
{
  public static class MoneyExtensions
  {
    public static Dollar Dollar(this Money money, int amount)
    {
      return new Dollar(amount);
    }
  }
}