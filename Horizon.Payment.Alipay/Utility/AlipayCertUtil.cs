﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using  Horizon.Core.Security;
using MD5 = Horizon.Core.Security.MD5;

namespace Horizon.Payment.Alipay.Utility
{
    /// <summary>
    /// 证书相关工具类
    /// </summary>
    public static class AlipayCertUtil
    {
        /// <summary>
        /// 提取根证书序列号
        /// </summary>
        /// <param name="rootCertificate">根证书</param>
        public static string GetRootCertSN(string rootCertificate)
        {
            var rootCertSN = string.Empty;

            var certs = ReadPemCertChain(rootCertificate);
            foreach (var cert in certs)
            {
                var sigAlgOid = string.Empty;

                try
                {
                    sigAlgOid = cert.SignatureAlgorithm.Value;
                }
                catch
                { }

                if (sigAlgOid.StartsWith("1.2.840.113549.1.1", StringComparison.Ordinal))
                {
                    var certSN = GetCertSN(cert);
                    if (string.IsNullOrEmpty(rootCertSN))
                    {
                        rootCertSN = certSN;
                    }
                    else
                    {
                        rootCertSN = rootCertSN + "_" + certSN;
                    }
                }
            }

            return rootCertSN;
        }

        /// <summary>
        /// 反序列化证书
        /// </summary>
        /// <param name="certificate">证书</param>
        public static X509Certificate2 Parse(string certificate)
        {
            return File.Exists(certificate) ? new X509Certificate2(certificate)
                : Base64Util.IsBase64String(certificate) ? new X509Certificate2(Convert.FromBase64String(certificate))
                : throw new AlipayException("证书文件不存在或证书的Base64String不正确！");
        }

        /// <summary>
        /// 计算指定证书的序列号
        /// </summary>
        /// <param name="certificate">证书</param>
        public static string GetCertSN(X509Certificate2 certificate)
        {
            // 删除逗号后面的空格
            var issuer = certificate.Issuer.ToString().Replace(", ", ",");

            //提取出的证书的issuerDN本身是以CN开头的，则无需逆序，直接返回
            if (issuer.StartsWith("CN", StringComparison.Ordinal))
            {
                return MD5.Compute(issuer + BigInteger.Parse(certificate.SerialNumber, NumberStyles.HexNumber).ToString()).ToLowerInvariant();
            }
            else
            {
                var attributes = issuer.Split(',').ToList();
                attributes.Reverse();

                return MD5.Compute(string.Join(",", attributes.ToArray()) + BigInteger.Parse(certificate.SerialNumber, NumberStyles.HexNumber).ToString()).ToLowerInvariant();
            }
        }

        /// <summary>
        /// 从证书中提取公钥
        /// </summary>
        /// <param name="certificate">证书</param>
        public static string GetCertPublicKey(X509Certificate2 certificate)
        {
            return Convert.ToBase64String(certificate.GetRSAPublicKey().ExportSubjectPublicKeyInfo());
        }

        /// <summary>
        /// 校验证书链是否可信
        /// </summary>
        /// <param name="certificate">需要验证的目标证书或者证书链</param>
        /// <param name="rootCertificate">可信根证书</param>
        public static bool IsTrusted(string certificate, string rootCertificate)
        {
            var rootCertificates = ReadPemCertChain(rootCertificate);
            var certificates = ReadPemCertChain(certificate);
            foreach (var cert in certificates)
            {
                using (var chain = X509Chain.Create())
                {
                    foreach (var rootCert in rootCertificates)
                    {
                        chain.ChainPolicy.ExtraStore.Add(rootCert);
                    }

                    chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
                    chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;

                    if (!chain.Build(cert))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 从证书链反序列化证书链集合
        /// </summary>
        /// <param name="certificate">证书链</param>
        private static List<X509Certificate2> ReadPemCertChain(string certificate)
        {
            var certChainStr = File.Exists(certificate) ? File.ReadAllText(certificate)
                : Base64Util.IsBase64String(certificate) ? Encoding.ASCII.GetString(Convert.FromBase64String(certificate))
                : throw new AlipayException("证书文件不存在或证书的Base64String不正确！");

            var certStrArr = certChainStr.Split("-----END CERTIFICATE-----", StringSplitOptions.RemoveEmptyEntries);

            var certs = new List<X509Certificate2>();
            foreach (var certStr in certStrArr)
            {
                certs.Add(new X509Certificate2(Encoding.ASCII.GetBytes(certStr + "-----END CERTIFICATE-----")));
            }

            return certs;
        }
    }

    public static class Base64Util
    {
        public static bool IsBase64String(string str)
        {
            Span<byte> buffer = stackalloc byte[str.Length];
            return Convert.TryFromBase64String(str, buffer, out _);
        }
    }
}
