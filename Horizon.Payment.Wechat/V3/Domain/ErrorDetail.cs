﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.WechatPay.V3.Domain
{
    /// <summary>
    /// 错误详情
    /// </summary>    
    public class ErrorDetail : WeChatPayObject
    {
        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}
