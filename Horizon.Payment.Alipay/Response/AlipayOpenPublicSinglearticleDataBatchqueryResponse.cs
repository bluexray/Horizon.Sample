using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicSinglearticleDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicSinglearticleDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 单篇文章分析数据列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<SingleArticleAnalysisData> DataList { get; set; }
    }
}
