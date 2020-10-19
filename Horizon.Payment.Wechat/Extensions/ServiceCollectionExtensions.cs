using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddHorizonWeChatPay(this IServiceCollection services)
        {
            services.AddHttpClient(Horizon.Payment.WechatPay.V2.WeChatPayClient.Name);
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, Horizon.Payment.WechatPay.V2.WeChatPayHttpMessageHandlerBuilderFilter>());
            services.AddSingleton<Horizon.Payment.WechatPay.V2.WeChatPayClientCertificateManager>();
            services.AddSingleton<Horizon.Payment.WechatPay.V2.IWeChatPayClient, Horizon.Payment.WechatPay.V2.WeChatPayClient>();
            services.AddSingleton<Horizon.Payment.WechatPay.V2.IWeChatPayNotifyClient, Horizon.Payment.WechatPay.V2.WeChatPayNotifyClient>();

            services.AddHttpClient(Horizon.Payment.WechatPay.V3.WeChatPayClient.Name);
            services.AddSingleton<Horizon.Payment.WechatPay.V3.WeChatPayPlatformCertificateManager>();
            services.AddSingleton<Horizon.Payment.WechatPay.V3.IWeChatPayClient, Horizon.Payment.WechatPay.V3.WeChatPayClient>();
            services.AddSingleton<Horizon.Payment.WechatPay.V3.IWeChatPayNotifyClient, Horizon.Payment.WechatPay.V3.WeChatPayNotifyClient>();
        }
    }
}
