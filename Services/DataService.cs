using CountryStateApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.NewFolder;

namespace CountryStateApi.Services
{
    public class DataService: IData
    {
        private readonly TaskDbContext _context;

        public DataService(TaskDbContext context)
        {
            _context = context;
        }
        public async Task<List<Country>> GetCountries()
        {
            var result = await this._context.Countries.ToListAsync();
            return result;
        }
        public async Task<List<State>> GetStates(int countryId)
        {
            var result = await this._context.States.Where(c=>c.Cid == countryId).ToListAsync();
            return result;
        }
        public async Task<int> AddCountryName(Country country)
        {
            var result=await this._context.Countries.AddAsync(country);
            return this._context.SaveChanges();
        }
        public async Task<int> UpdateCountryName(Country country)
        {
            var _country=await this._context.Countries.Where(c=>c.Id==country.Id).FirstOrDefaultAsync();
            _country.Name= country.Name;
            return this._context.SaveChanges();
        }
        public async Task<int> DeleteCountryName(int id)
        {
            var _country = await this._context.Countries.Where(c => c.Id == id).FirstOrDefaultAsync();
            this._context.Countries.Remove(_country);
            return this._context.SaveChanges();
        }
    }
}
