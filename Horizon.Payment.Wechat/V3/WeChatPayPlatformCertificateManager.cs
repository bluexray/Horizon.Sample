﻿using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace Horizon.Payment.WechatPay.V3
{
    public class WeChatPayPlatformCertificateManager
    {
        private readonly ConcurrentDictionary<string, X509Certificate2> _certificateDictionary = new ConcurrentDictionary<string, X509Certificate2>();

        public bool ContainsKey(string serialNo) => _certificateDictionary.ContainsKey(serialNo);

        public bool TryAdd(string serialNo, X509Certificate2 certificate) => _certificateDictionary.TryAdd(serialNo, certificate);

        public bool TryGetValue(string serialNo, out X509Certificate2 certificate) => _certificateDictionary.TryGetValue(serialNo, out certificate);
    }
}
