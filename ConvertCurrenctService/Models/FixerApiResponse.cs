using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoricalRatesService.Models
{
    public class FixerApiResponse
    {
        public bool Success { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
        public ApiError Error { get; set; }
    }
}