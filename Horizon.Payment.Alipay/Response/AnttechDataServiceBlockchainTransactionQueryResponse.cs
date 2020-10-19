using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainTransactionQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainTransactionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易列表
        /// </summary>
        [JsonPropertyName("transaction_list")]
        public List<BlockChainTransactionApiDO> TransactionList { get; set; }
    }
}
