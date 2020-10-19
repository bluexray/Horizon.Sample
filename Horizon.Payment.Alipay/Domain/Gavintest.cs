﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// Gavintest Data Structure.
    /// </summary>
    public class Gavintest : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("newid")]
        public long Newid { get; set; }
    }
}
