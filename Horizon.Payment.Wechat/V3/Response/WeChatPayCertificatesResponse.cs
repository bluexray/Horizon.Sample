using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.WechatPay.V3.Domain;

namespace Horizon.Payment.WechatPay.V3.Response
{
    public class WeChatPayCertificatesResponse : WeChatPayResponse
    {
        [JsonPropertyName("data")]
        public List<Certificate> Certificates { get; set; }
    }
}
