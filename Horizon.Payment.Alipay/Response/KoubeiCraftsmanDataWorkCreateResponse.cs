using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品id
        /// </summary>
        [JsonPropertyName("works")]
        public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
    }
}
