﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseCommonImageUploadModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseCommonImageUploadModel : AlipayObject
    {
        /// <summary>
        /// 文件内容字节数组Base64字符串,最大支持上传5M的文件
        /// </summary>
        [JsonPropertyName("file_base")]
        public string FileBase { get; set; }

        /// <summary>
        /// 文件类型  1：图片（支持jpg、png、jpeg、bmp格式）   2：合同（HTML格式）
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// true|false是否公共读写，私密文件使用否，如电子合同
        /// </summary>
        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }
    }
}
