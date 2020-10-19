﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMenuDataBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMenuDataBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonPropertyName("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束日期，开始日期/结束日期时间跨度最大30天
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }
    }
}
