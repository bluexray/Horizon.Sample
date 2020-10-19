﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdiePreviewQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdiePreviewQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 站点页面预览数据返回值
        /// </summary>
        [JsonPropertyName("data")]
        public FengdiePreviewQueryRespModel Data { get; set; }
    }
}
