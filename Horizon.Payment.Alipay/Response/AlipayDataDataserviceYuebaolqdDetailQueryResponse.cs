﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceYuebaolqdDetailQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceYuebaolqdDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 余额宝清算日预测申赎数据
        /// </summary>
        [JsonPropertyName("yeb_ldq_data")]
        public List<AlipayYebLqdDataResult> YebLdqData { get; set; }
    }
}
