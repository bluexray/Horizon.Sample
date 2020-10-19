using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceFixAttachmentUploadResponse.
    /// </summary>
    public class AlipayCommerceFixAttachmentUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传文件的内容。
        /// </summary>
        [JsonPropertyName("file_info")]
        public FixFileInfo FileInfo { get; set; }
    }
}
