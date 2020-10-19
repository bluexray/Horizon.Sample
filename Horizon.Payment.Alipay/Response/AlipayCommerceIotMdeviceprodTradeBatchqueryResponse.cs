using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodTradeBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodTradeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// iot交易设备信息列表
        /// </summary>
        [JsonPropertyName("result_list")]
        public List<DeviceTradeResponse> ResultList { get; set; }
    }
}
