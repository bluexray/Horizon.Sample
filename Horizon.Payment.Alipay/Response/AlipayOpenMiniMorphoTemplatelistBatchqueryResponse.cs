using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMorphoTemplatelistBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniMorphoTemplatelistBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模板列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<MorphoTemplateItem> DataList { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonPropertyName("paginator")]
        public MorphoPaginator Paginator { get; set; }
    }
}
