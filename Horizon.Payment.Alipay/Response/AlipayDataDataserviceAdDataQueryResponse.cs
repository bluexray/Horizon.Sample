using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDataQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇总结果数据列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<DataDetail> DataList { get; set; }
    }
}
