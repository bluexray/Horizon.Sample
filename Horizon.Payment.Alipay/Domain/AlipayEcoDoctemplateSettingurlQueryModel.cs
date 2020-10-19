using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoDoctemplateSettingurlQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoDoctemplateSettingurlQueryModel : AlipayObject
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
