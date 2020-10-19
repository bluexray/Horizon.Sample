﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppCategoryInfo Data Structure.
    /// </summary>
    public class MiniAppCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 一级类目id
        /// </summary>
        [JsonPropertyName("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [JsonPropertyName("first_category_name")]
        public string FirstCategoryName { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        [JsonPropertyName("second_category_id")]
        public string SecondCategoryId { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [JsonPropertyName("second_category_name")]
        public string SecondCategoryName { get; set; }
    }
}
