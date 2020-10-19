﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoGetResponse : AlipayResponse
    {
        /// <summary>
        /// 电子发票详情模型
        /// </summary>
        [JsonPropertyName("invoice_model")]
        public InvoiceModelContent InvoiceModel { get; set; }
    }
}
