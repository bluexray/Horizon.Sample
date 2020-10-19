using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosParamQueryResponse.
    /// </summary>
    public class KoubeiCateringPosParamQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店参数model
        /// </summary>
        [JsonPropertyName("param_model")]
        public ParamModel ParamModel { get; set; }
    }
}
