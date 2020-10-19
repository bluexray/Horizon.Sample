using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelRateCurrencyBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTravelRateCurrencyBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率币种列表
        /// </summary>
        [JsonPropertyName("currency_list")]
        public List<RateCurrency> CurrencyList { get; set; }
    }
}
