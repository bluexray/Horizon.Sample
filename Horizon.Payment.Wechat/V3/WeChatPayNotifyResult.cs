﻿#if NETCOREAPP3_1

using Microsoft.AspNetCore.Mvc;

namespace Horizon.Payment.WechatPay.V3
{
    /// <summary>
    /// WeChatPay V3 通知应答
    /// </summary>
    public static class WeChatPayNotifyResult
    {
        private static readonly ContentResult success = new ContentResult { Content = "{\"code\":\"SUCCESS\",\"message\":\"SUCCESS\"}", ContentType = "application/json", StatusCode = 200 };
        private static readonly ContentResult failure = new ContentResult { Content = "{\"code\":\"FAIL\",\"message\":\"FAIL\"}", ContentType = "application/json", StatusCode = 500 };

        /// <summary>
        /// 成功
        /// </summary>
        public static IActionResult Success => success;

        /// <summary>
        /// 失败
        /// </summary>
        public static IActionResult Failure => failure;
    }
}

#endif
