﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserPassGrouplistQueryResponse.
    /// </summary>
    public class AlipayUserPassGrouplistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券信息列表
        /// </summary>
        [JsonPropertyName("pass_info_list")]
        public List<PassInfoOpenApiModel> PassInfoList { get; set; }
    }
}
