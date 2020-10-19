using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [JsonPropertyName("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
