using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorCityQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorCityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 城市列表
        /// </summary>
        [JsonPropertyName("citys")]
        public List<CityFunction> Citys { get; set; }
    }
}
