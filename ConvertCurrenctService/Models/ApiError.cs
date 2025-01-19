using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoricalRatesService.Models
{
    public class ApiError
    {
        public int Code { get; set; }
        public string Info { get; set; }
    }
}