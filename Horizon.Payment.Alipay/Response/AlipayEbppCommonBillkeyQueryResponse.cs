using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommonBillkeyQueryResponse.
    /// </summary>
    public class AlipayEbppCommonBillkeyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 户号列表
        /// </summary>
        [JsonPropertyName("bill_key_list")]
        public List<EbppBillKey> BillKeyList { get; set; }
    }
}
