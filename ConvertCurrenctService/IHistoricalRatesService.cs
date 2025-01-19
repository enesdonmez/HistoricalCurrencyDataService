using HistoricalRatesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalRatesService
{

    [ServiceContract]
    public interface IHistoricalRatesService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetExchangeRates", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Task<FixerApiResponse> GetExchangeRates(string Date, string Base, List<string> Symbols);

        [OperationContract]
        [WebGet(UriTemplate = "/GetSupportedCurrencies", ResponseFormat = WebMessageFormat.Json)]
        Task<List<string>> GetSupportedCurrencies();
    }
}
