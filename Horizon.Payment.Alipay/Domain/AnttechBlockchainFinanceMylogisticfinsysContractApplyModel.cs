﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysContractApplyModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsysContractApplyModel : AlipayObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("contract_name")]
        public string ContractName { get; set; }
    }
}
