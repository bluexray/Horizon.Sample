using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserinfoQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑子账号数据列表
        /// </summary>
        [JsonPropertyName("sub_cloud_user_list")]
        public List<SubCloudUserInfo> SubCloudUserList { get; set; }
    }
}
