﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayToolsFileUploadResponse.
    /// </summary>
    public class AlipayToolsFileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
