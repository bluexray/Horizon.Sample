using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAppinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 应用信息列表
        /// </summary>
        [JsonPropertyName("app_basic_info_response_list")]
        public List<AppBasicInfoResponse> AppBasicInfoResponseList { get; set; }
    }
}
