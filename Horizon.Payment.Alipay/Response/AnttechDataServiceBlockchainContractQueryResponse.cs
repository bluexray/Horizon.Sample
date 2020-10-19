using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainContractQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainContractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约列表
        /// </summary>
        [JsonPropertyName("contract_list")]
        public List<BlockChainContractApiDO> ContractList { get; set; }
    }
}
