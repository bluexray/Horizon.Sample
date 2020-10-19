using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataDiseaseQueryResponse.
    /// </summary>
    public class AlipayInsDataDiseaseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 匹配的疾病
        /// </summary>
        [JsonPropertyName("disease_list")]
        public List<DiseaseDTO> DiseaseList { get; set; }
    }
}
