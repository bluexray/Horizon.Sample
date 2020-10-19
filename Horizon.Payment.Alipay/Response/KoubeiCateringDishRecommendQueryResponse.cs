using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRecommendQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐菜品列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<DishRecommend> DishList { get; set; }
    }
}
