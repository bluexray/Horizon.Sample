﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMessagespecifyPushResponse.
    /// </summary>
    public class AlipayMobilePublicMessagespecifyPushResponse : AlipayResponse
    {
        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
