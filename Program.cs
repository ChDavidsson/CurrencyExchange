using System.Formats.Asn1;
using System.Globalization;

namespace CurrencyExchange;

class Program
{
    static void Main(string[] args)
    {
        // 1. Valutaomvandlare
        // Skapa en konsolapplikation som konverterar en summa pengar från en valuta till en annan. Inkludera typkonverteringar, operatörer och kontrollflöde.
        // Instruktioner:
        Console.WriteLine("Welcome to currency exchange");

        // Be användaren att ange en summa pengar i SEK.
        Console.WriteLine("Please enter amount in SEK you want to exchange:");
        decimal inputAmount = decimal.Parse(Console.ReadLine()!);

        // Ange en lista över tillgängliga valutor (t.ex. EUR, GBP, JPY,USD).
        Console.WriteLine("Choose which currency you want to exchange to:");
        Console.WriteLine("1. EUR");
        Console.WriteLine("2. GBP");
        Console.WriteLine("3. JPY");
        Console.WriteLine("4. USD");
        string chosenCurrency = (Console.ReadLine()!).ToUpper();

        // Använd en switch-sats för att hantera valutaomvandlingen.
        decimal exchangeValueCurrency;
        switch (chosenCurrency)
        // Utför omvandlingen med multiplikationsoperatorer och skriv gjutning vid behov.
            {
                case "EUR":
                    exchangeValueCurrency = inputAmount * 0.092m;
                    break;
                
                case "GBP":
                    exchangeValueCurrency = inputAmount * 0.079m;
                    break;
                
                case "JPY":
                    exchangeValueCurrency = inputAmount * 15.748m;
                    break;

                case "USD":
                    exchangeValueCurrency = inputAmount * 0.099m;
                    break;
                
                default:
                    Console.WriteLine("Not a currency");
                    return;
                }
                // Visa det konverterade beloppet.
            Console.WriteLine($"Your currency {inputAmount}SEK is {exchangeValueCurrency}{chosenCurrency}");

            Console.ReadLine();
        
    }
}
