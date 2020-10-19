using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeBankRootQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBankRootQueryResponse : AlipayResponse
    {
        /// <summary>
        /// Institution列表
        /// </summary>
        [JsonPropertyName("bank_details")]
        public List<Institution> BankDetails { get; set; }
    }
}
