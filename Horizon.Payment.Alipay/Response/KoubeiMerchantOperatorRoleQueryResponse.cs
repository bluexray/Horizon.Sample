﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleQueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 角色信息包含角色ID和角色名称,以及权限汇总信息
        /// </summary>
        [JsonPropertyName("list")]
        public List<KoubeiMerchantRole> List { get; set; }
    }
}
