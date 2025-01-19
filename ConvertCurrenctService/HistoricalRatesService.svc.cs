using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HistoricalRatesService.Models;
using ConvertCurrenctService.Models;
using System.Linq;

namespace HistoricalRatesService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HistoricalRatesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HistoricalRatesService.svc or HistoricalRatesService.svc.cs at the Solution Explorer and start debugging.
    public class HistoricalRatesService : IHistoricalRatesService
    {
        private const string ApiKey = "65d04c0bda34c4e9679d4bb5a205803f";
        private const string BaseUrl = "http://data.fixer.io/api/";


        public async Task<List<string>> GetSupportedCurrencies()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{BaseUrl}/symbols?access_key={ApiKey}";
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Failed to retrieve exchange rates.");

                string content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SupportedCurrencies>(content);

                if (!data.success)
                    throw new Exception($"Error fetching data: {data.Error?.Info}");

                return new List<string>(data.symbols.GetType().GetProperties().Select(p => p.Name));
            }
        }

        public async Task<FixerApiResponse> GetExchangeRates(string Date, string Base, List<string> Symbols)
        {
            using (HttpClient client = new HttpClient())
            {
                string symbolsParam = string.Join(",", Symbols);
                string url = $"{BaseUrl}/{Date}?access_key={ApiKey}&base={Base}&symbols={symbolsParam}";

                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    return new FixerApiResponse
                    {
                        Success = false,
                        Error = new ApiError
                        {
                            Code = (int)response.StatusCode,
                            Info = response.ReasonPhrase
                        }
                    };

                string content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<FixerApiResponse>(content);

                if (!data.Success)
                    return new FixerApiResponse
                    {
                        Success = false,
                        Error = new ApiError
                        {
                            Code = 500,
                            Info = "Failed to retrieve exchange rates."
                        }
                    };

                return new FixerApiResponse

                {
                    Success = true,
                    Rates = data.Rates
                };
            }

        }
    }
}
