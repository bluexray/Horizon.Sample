﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序的版本号列表
        /// </summary>
        [JsonPropertyName("app_versions")]
        public List<string> AppVersions { get; set; }
    }
}
