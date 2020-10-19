using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [JsonPropertyName("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}
