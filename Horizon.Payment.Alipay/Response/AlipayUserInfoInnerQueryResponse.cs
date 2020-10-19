﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInfoInnerQueryResponse.
    /// </summary>
    public class AlipayUserInfoInnerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定手机号码
        /// </summary>
        [JsonPropertyName("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 优先返回登录邮箱，若邮箱不存在，返回其他登录号（登录手机号）
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 阿里集团统一ID
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 金融机构或特殊单位 I:金融机构 C:特殊单位 N:非金融机构或特殊单位
        /// </summary>
        [JsonPropertyName("inst_type")]
        public string InstType { get; set; }

        /// <summary>
        /// 账户是否禁止提现，T是，F否
        /// </summary>
        [JsonPropertyName("is_forbidden_withdraw")]
        public string IsForbiddenWithdraw { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; }
    }
}
