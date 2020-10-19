﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠业务用户与商户的关系
        /// </summary>
        [JsonPropertyName("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
