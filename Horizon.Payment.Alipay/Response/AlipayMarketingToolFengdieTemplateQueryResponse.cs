using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开发者开发上传的H5模板列表
        /// </summary>
        [JsonPropertyName("template")]
        public List<FengdieTemplate> Template { get; set; }
    }
}
