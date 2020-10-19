﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Horizon.Core.Security;
using Horizon.Payment.WechatPay.V2.Parser;
using MD5 = Horizon.Core.Security.MD5;

namespace Horizon.Payment.WechatPay.V2
{
    public class WeChatPayNotifyClient : IWeChatPayNotifyClient
    {
        #region WeChatPayNotifyClient Constructors

        public WeChatPayNotifyClient()
        {
        }

        #endregion

        #region IWeChatPayNotifyClient Members

#if NETCOREAPP3_1
        public async Task<T> ExecuteAsync<T>(Microsoft.AspNetCore.Http.HttpRequest request, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            request.Body.Seek(0, SeekOrigin.Begin);
            using (var reader = new StreamReader(request.Body, Encoding.UTF8))
            {
                var body = await reader.ReadToEndAsync();
                return await ExecuteAsync<T>(body, options);
            }
        }
#endif

        #endregion

        #region IWeChatPayNotifyClient Members

        public Task<T> ExecuteAsync<T>(string body, WeChatPayOptions options) where T : WeChatPayNotify
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new ArgumentNullException(nameof(options.Key));
            }

            var parser = new WeChatPayNotifyXmlParser<T>();
            var notify = parser.Parse(body);
            if (notify is Notify.WeChatPayRefundNotify)
            {
                var key = MD5.Compute(options.Key).ToLowerInvariant();
                var data = AesHelper.Decrypt((notify as Notify.WeChatPayRefundNotify).ReqInfo, key); //todo  PKCS7  Encrypt
                notify = parser.Parse(body, data);
            }
            else
            {
                CheckNotifySign(notify, options);
            }

            return Task.FromResult(notify);
        }

        #endregion

        #region Common Method

        private void CheckNotifySign(WeChatPayNotify notify, WeChatPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (notify.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (!notify.Parameters.TryGetValue("sign", out var sign))
            {
                throw new WeChatPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = WeChatPaySignature.SignWithKey(notify.Parameters, options.Key, WeChatPaySignType.MD5);
            if (cal_sign != sign)
            {
                throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
