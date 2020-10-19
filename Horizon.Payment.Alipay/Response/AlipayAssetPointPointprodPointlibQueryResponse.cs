﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodPointlibQueryResponse.
    /// </summary>
    public class AlipayAssetPointPointprodPointlibQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 集分宝积分库查询结果，包含积分库ID，名称，余额等
        /// </summary>
        [JsonPropertyName("result")]
        public PointLibResult Result { get; set; }
    }
}
