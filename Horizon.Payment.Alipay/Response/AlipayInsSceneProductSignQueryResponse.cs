﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneProductSignQueryResponse.
    /// </summary>
    public class AlipayInsSceneProductSignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
