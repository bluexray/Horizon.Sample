using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberphoneSyncResponse.
    /// </summary>
    public class KoubeiServindustryExerciseMemberphoneSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 健身用户手机号与健身用户id映射
        /// </summary>
        [JsonPropertyName("mapping_list")]
        public List<ExerciseUserMappingDTO> MappingList { get; set; }
    }
}
