using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品列表
        /// </summary>
        [JsonPropertyName("opuses")]
        public OpusCreateResponse Opuses { get; set; }
    }
}
