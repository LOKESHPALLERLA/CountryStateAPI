using WebApplication1.NewFolder;

namespace CountryStateApi.Services.Interfaces
{
    public interface IData
    {
        Task<List<Country>> GetCountries();
        Task<List<State>> GetStates(int id);
        Task<int> AddCountryName(Country country);
        Task<int> UpdateCountryName(Country country);
        Task<int> DeleteCountryName(int id);
    }
}
