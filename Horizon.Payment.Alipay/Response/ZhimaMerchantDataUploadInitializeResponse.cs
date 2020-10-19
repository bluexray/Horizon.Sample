﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantDataUploadInitializeResponse.
    /// </summary>
    public class ZhimaMerchantDataUploadInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 行业模板
        /// </summary>
        [JsonPropertyName("template_url")]
        public string TemplateUrl { get; set; }
    }
}
