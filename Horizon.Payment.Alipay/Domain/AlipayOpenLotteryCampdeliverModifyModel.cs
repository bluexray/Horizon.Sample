﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampdeliverModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenLotteryCampdeliverModifyModel : AlipayObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [JsonPropertyName("env")]
        public string Env { get; set; }
    }
}
