﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsWarehouseQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsWarehouseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 仓库信息
        /// </summary>
        [JsonPropertyName("warehouses")]
        public List<WarehouseVO> Warehouses { get; set; }
    }
}
