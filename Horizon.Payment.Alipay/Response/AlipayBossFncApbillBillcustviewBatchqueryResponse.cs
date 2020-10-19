﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncApbillBillcustviewBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncApbillBillcustviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 应付月账单客户视图
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ApMonthlyBillCustOpenApiResponse> ResultSet { get; set; }
    }
}
