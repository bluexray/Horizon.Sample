﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduCampusJobPublishResponse.
    /// </summary>
    public class AlipayEcoEduCampusJobPublishResponse : AlipayResponse
    {
        /// <summary>
        /// 备注问题，或者异常
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 返回code编码;成功返回SUCCESS
        /// </summary>
        [JsonPropertyName("isv_code")]
        public string IsvCode { get; set; }
    }
}
