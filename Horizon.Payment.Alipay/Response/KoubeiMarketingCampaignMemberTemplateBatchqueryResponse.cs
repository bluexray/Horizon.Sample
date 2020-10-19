using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员模板模型
        /// </summary>
        [JsonPropertyName("member_templates")]
        public List<MerchantMemberTemplateModel> MemberTemplates { get; set; }
    }
}
