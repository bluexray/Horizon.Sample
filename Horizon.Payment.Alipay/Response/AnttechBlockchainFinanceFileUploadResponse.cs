using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFileUploadResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传成功后返回文件信息
        /// </summary>
        [JsonPropertyName("file_info")]
        public FinanceFileInfo FileInfo { get; set; }
    }
}
