﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaOpenQerqQerqQueryModel Data Structure.
    /// </summary>
    public class ZhimaOpenQerqQerqQueryModel : AlipayObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [JsonPropertyName("address")]
        public AgreementParams Address { get; set; }
    }
}
