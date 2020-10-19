using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossContractManagementQueryResponse.
    /// </summary>
    public class AlipayBossContractManagementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public ContractBatchInfoOpenApiResult ResultSet { get; set; }
    }
}
