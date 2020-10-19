﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetreverseAssignSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，处理结果
        /// </summary>
        [JsonPropertyName("delivery_results")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
