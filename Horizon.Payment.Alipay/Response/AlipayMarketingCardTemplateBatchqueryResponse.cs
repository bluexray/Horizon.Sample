using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员卡模板基本信息
        /// </summary>
        [JsonPropertyName("mcard_template")]
        public List<McardTemplate> McardTemplate { get; set; }

        /// <summary>
        /// 会员卡模板总数
        /// </summary>
        [JsonPropertyName("template_total")]
        public long TemplateTotal { get; set; }
    }
}
