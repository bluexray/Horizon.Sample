﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockBizQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
