using HA.Entities;

namespace HA.Plugins.Interfaces.Repository
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetCurrencies();

        Currency GetCurrencyById(int currencyId);

        void AddCurrency(Currency currency);

        void UpdateCurrency(Currency currency);

        void DeleteCurrency(int currencyId);

        void DeleteCurrency(Currency currency);
    }
}
