﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateSendResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateSendResponse : AlipayResponse
    {
        /// <summary>
        /// 分配模板的操作是否成功
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
