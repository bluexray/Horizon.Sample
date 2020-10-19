﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("parking_goods_detail")]
        public ParkingGoodsDetail ParkingGoodsDetail { get; set; }
    }
}
