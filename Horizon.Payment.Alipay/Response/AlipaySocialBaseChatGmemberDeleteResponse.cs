﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberDeleteResponse.
    /// </summary>
    public class AlipaySocialBaseChatGmemberDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [JsonPropertyName("result_delete")]
        public bool ResultDelete { get; set; }
    }
}
