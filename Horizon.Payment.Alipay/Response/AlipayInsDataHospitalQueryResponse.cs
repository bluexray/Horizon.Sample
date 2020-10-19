using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataHospitalQueryResponse.
    /// </summary>
    public class AlipayInsDataHospitalQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 名称相似度Top10的医院
        /// </summary>
        [JsonPropertyName("hospitals")]
        public List<HospitalDTO> Hospitals { get; set; }
    }
}
