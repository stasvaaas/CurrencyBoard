namespace CurrencyBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board<int> usd = new Board<int>("USD");
            usd.ChangeRate(10);
            usd.ChangeRate(30);
            usd.ChangeRate(40);
            usd.PrintHistory();

            Board<double> eur = new Board<double>("EUR");
            eur.ChangeRate(10);
            eur.ChangeRate(15.3);
            eur.ChangeRate(55.2);
            eur.PrintHistory();
        }
    }
}