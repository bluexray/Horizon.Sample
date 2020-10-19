using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<MiniAppCategory> CategoryList { get; set; }
    }
}
