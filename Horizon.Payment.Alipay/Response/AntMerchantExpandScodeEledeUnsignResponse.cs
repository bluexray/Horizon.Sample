using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandScodeEledeUnsignResponse.
    /// </summary>
    public class AntMerchantExpandScodeEledeUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 去标返回结果
        /// </summary>
        [JsonPropertyName("remove_tag_response")]
        public RemoveTagResponse RemoveTagResponse { get; set; }
    }
}
