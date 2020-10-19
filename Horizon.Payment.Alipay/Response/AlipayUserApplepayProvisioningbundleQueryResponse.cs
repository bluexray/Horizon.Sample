﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleQueryResponse.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 卡状态
        /// </summary>
        [JsonPropertyName("pass_state")]
        public string PassState { get; set; }

        /// <summary>
        /// 卡模型
        /// </summary>
        [JsonPropertyName("provisioning_bundle")]
        public OpenApiProvisioningBundle ProvisioningBundle { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [JsonPropertyName("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
