﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingCardbarcodeCreateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingCardbarcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 停车车卡对应二维码列表
        /// </summary>
        [JsonPropertyName("qrcodes")]
        public List<QRcode> Qrcodes { get; set; }
    }
}
