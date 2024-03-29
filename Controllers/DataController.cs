using CountryStateApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using WebApplication1.NewFolder;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        private IData _data;
        public DataController(IData data)
        {
            this._data = data;
        }
        [HttpGet("GetCountries")]
        public async Task<List<Country>> GetCountries()
        {
            var result = await this._data.GetCountries();
            return result;
        }
        [HttpGet("GetStates/{countryId}")]
        public async Task<List<State>> GetStates(int countryId)
        {
            var result = await this._data.GetStates(countryId);
            return result;
        }
        [HttpPost("AddCountryName")]
        public async Task<int> AddCountryName([FromForm]Country country)
        {
            var result=await this._data.AddCountryName(country);
            return result;
        }
        [HttpPut("UpdateCountryName")]
        public async Task<int> UpdateCountryName([FromForm]Country country)
        {
            var result = await this._data.UpdateCountryName(country);
            return result;
        }
        [HttpDelete("DeleteCountryName/{countryId}")]
        public async Task<int> DeleteCountryName(int countryId)
        {
            var result = await this._data.DeleteCountryName(countryId);
            return result;
        }
    }
}
